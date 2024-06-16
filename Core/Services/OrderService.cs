using AutoMapper;
using Core.DTOs.UserInfo;
using Core.Entities.UserEntity;
using Core.Entities.UserInfo;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Identity;
using System.Numerics;
using static Core.Specification.OrderSpecification;

namespace Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderItems> _orderItemsRepository;
        private readonly IRepository<Bag> _bagRepository;
        private readonly IRepository<BagItems> _bagItemsRepository;
        private readonly IRepository<Address> _addressRepository;
        private readonly IRepository<UserBonuses> _userBonuses;
        private readonly UserManager<User> _userManager;
        public OrderService(IRepository<Order> repositoryRepository, IMapper mapper, IRepository<Bag> bagRepository, UserManager<User> userManager, IRepository<BagItems> bagItemsRepository, IRepository<OrderItems> orderItemsRepository, IRepository<Address> addressRepository, IRepository<UserBonuses> userBonuses)
        {
            _mapper = mapper;
            _orderRepository = repositoryRepository;
            _bagRepository = bagRepository;
            _userManager = userManager;
            _bagItemsRepository = bagItemsRepository;
            _orderItemsRepository = orderItemsRepository;
            _addressRepository = addressRepository;
            _userBonuses = userBonuses;
        }
        public async Task CreateAsync(OrderCreateDTO orderCreateDTO)
        {
            var user = await _userManager.FindByEmailAsync(orderCreateDTO.EmailUser);
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(orderCreateDTO.EmailUser));
            var bagItems = await _bagItemsRepository.GetListBySpec(new BagItemsSpecification.GetBagItemsByBagEmail(orderCreateDTO.EmailUser));

            if (bag != null)
            {
                Address address = new Address()
                {
                    City = orderCreateDTO.City,
                    Region = orderCreateDTO.Region,
                    Street = orderCreateDTO.Street,
                };
                await _addressRepository.InsertAsync(address);
                await _addressRepository.SaveAsync();

                decimal total = bagItems.Sum(p => p.Quantity * p.Product.Price);
                decimal tax = (bagItems.Sum(p => p.Quantity * p.Product.Price) / (100 + 20)) * 20;
                decimal subtotal = total - tax;
                decimal accrued = (1.0m / 100) * total;

                Order order = new Order()
                {
                    AddressId = address.Id,
                    Email = orderCreateDTO.Email,
                    EmailUser = orderCreateDTO.EmailUser,
                    FirstName = orderCreateDTO.FirstName,
                    LastName = orderCreateDTO.LastName,
                    OrderDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    PhoneNumber = orderCreateDTO.PhoneNumber,
                    Payment = orderCreateDTO.Payment,
                    UserId = user.Id,
                    OrderTotal = total,
                    Tax = tax,
                    Subtotal = subtotal,
                    Discount = 0,
                };
                await _orderRepository.InsertAsync(order);
                await _orderRepository.SaveAsync();

                if (user != null)
                {
                    user.BagId = null;
                    user.BonusBalance += accrued;
                    var result = await _userManager.UpdateAsync(user);
                }

                foreach (var item in bagItems)
                {
                    OrderItems orderItems = new OrderItems()
                    {
                        Quantity = item.Quantity,
                        Name = item.Product.Name,
                        Price = item.Product.Price,
                        Size = item.Size,
                        Article = item.Product.Article,
                        ImagePath = item.Product.Images.OrderBy(img => img.Id).FirstOrDefault().ImagePath,
                        OrderId = order.Id,
                        ProductId = item.ProductId,
                        Description = item.Product.Description,
                        Step = 0,
                        Status = "Order placed",
                    };
                    await _orderItemsRepository.InsertAsync(orderItems);
                    await _orderItemsRepository.SaveAsync();
                }
                await _bagRepository.DeleteAsync(bag.Id);
                await _bagRepository.SaveAsync();

                UserBonuses bonuses = new UserBonuses()
                {
                    OrderDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    UserId = user.Id,
                    Name = order.Id,
                    BonusesAccrued = accrued,
                    BonusesDescription = "Purchase bonus",
                    BonusesOperation = "Accrual",
                };
                await _userBonuses.InsertAsync(bonuses);
                await _userBonuses.SaveAsync();

            }
        }
        public async Task<List<OrderDTO>> GetAllOrdersAsync()
        {
            var result = await _orderRepository.GetListBySpec(new OrderSpecification.GetAllOrders());
            return _mapper.Map<List<OrderDTO>>(result);
        }
        public async Task<List<OrderDTO>> GetOrderByEmailAsync(string email, int page)
        {
            var result = await _orderRepository.GetListBySpec(new OrderSpecification.GetOrderByEmail(email, page));
            return _mapper.Map<List<OrderDTO>>(result);
        }
        public async Task<int> GetCountOrderByEmailAsync(string email)
        {
            var orders = await _orderRepository.GetListBySpec(new OrderSpecification.GetOrderCountByEmailSpecification(email));
            return orders.Count();
        }
    }
}
