using AutoMapper;
using Core.DTOs.UserInfo;
using Core.Entities.Address;
using Core.Entities.UserEntity;
using Core.Entities.UserInfo;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Identity;
using static Core.Specification.OrderSpecification;

namespace Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderPayment> _orderPaymentRepository;
        private readonly IRepository<OrderItems> _orderItemsRepository;
        private readonly IRepository<Bag> _bagRepository;
        private readonly IRepository<BagItems> _bagItemsRepository;
        private readonly IRepository<AddressEntity> _addressRepository;
        private readonly IRepository<UserBonuses> _userBonuses;
        private readonly UserManager<User> _userManager;
        public OrderService(IRepository<Order> repositoryRepository, IMapper mapper, IRepository<Bag> bagRepository, UserManager<User> userManager, IRepository<BagItems> bagItemsRepository, IRepository<OrderItems> orderItemsRepository, IRepository<AddressEntity> addressRepository, IRepository<UserBonuses> userBonuses, IRepository<OrderPayment> orderPaymentRepository)
        {
            _mapper = mapper;
            _orderRepository = repositoryRepository;
            _bagRepository = bagRepository;
            _userManager = userManager;
            _bagItemsRepository = bagItemsRepository;
            _orderItemsRepository = orderItemsRepository;
            _addressRepository = addressRepository;
            _userBonuses = userBonuses;
            _orderPaymentRepository = orderPaymentRepository;
        }
        public async Task CreateAsync(OrderCreateDTO orderCreateDTO)
        {
            var user = await _userManager.FindByEmailAsync(orderCreateDTO.EmailUser);
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(orderCreateDTO.EmailUser));
            var bagItems = await _bagItemsRepository.GetListBySpec(new BagItemsSpecification.GetBagItemsByBagEmail(orderCreateDTO.EmailUser));

            if (bag != null)
            {
                var address = await CreateAddressAsync(orderCreateDTO);
                var orderPayment = await CreateOrderPaymentAsync(orderCreateDTO);

                var (total, tax, subtotal, accrued) = CalculateOrderTotals(bagItems, orderCreateDTO.Discount);

                var order = await CreateOrderAsync(orderCreateDTO, address.Id, user.Id, orderPayment.Id, total, tax, subtotal);

                if (user != null)
                {
                    await UpdateUserAsync(user, orderCreateDTO.Discount, accrued);
                }

                await CreateOrderItemsAsync(bagItems, order.Id);
                await ClearBagAsync(bag.Id);

                await CreateUserBonusesAsync(user.Id, order.Id, orderCreateDTO.Discount, accrued);
            }
        }
        public async Task<List<OrderDTO>> GetAllOrdersAsync()
        {
            var result = await _orderRepository.GetListBySpec(new OrderSpecification.GetAllOrders());
            return _mapper.Map<List<OrderDTO>>(result);
        }
        public async Task<List<OrderDTO>> GetOrderByIdAsync(string Id, int page)
        {
            var result = await _orderRepository.GetListBySpec(new GetOrderById(Id, page));
            return _mapper.Map<List<OrderDTO>>(result);
        }
        public async Task<int> GetCountOrderByIdAsync(string Id)
        {
            var orders = await _orderRepository.GetListBySpec(new GetOrderCountByIdSpecification(Id));
            return orders.Count();
        }
        private async Task<AddressEntity> CreateAddressAsync(OrderCreateDTO orderCreateDTO)
        {
            AddressEntity address = new AddressEntity()
            {
                Country = orderCreateDTO.Country,
                City = orderCreateDTO.City,
                State = orderCreateDTO.State,
                Street = orderCreateDTO.Street,
            };
            await _addressRepository.InsertAsync(address);
            await _addressRepository.SaveAsync();
            return address;
        }
        private async Task<OrderPayment> CreateOrderPaymentAsync(OrderCreateDTO orderCreateDTO)
        {
            OrderPayment orderPayment = new OrderPayment()
            {
                Payment = orderCreateDTO.Payment,
                PaymentMethod = orderCreateDTO.PaymentMethod,
                CardHolderName = orderCreateDTO.CardHolderName,
                CardNumber = orderCreateDTO.CardNumber,
                CardMonthExpires = orderCreateDTO.CardMonthExpires,
                CardYearExpires = orderCreateDTO.CardYearExpires,
            };

            await _orderPaymentRepository.InsertAsync(orderPayment);
            await _orderPaymentRepository.SaveAsync();
            return orderPayment;
        }
        private (decimal total, decimal tax, decimal subtotal, decimal accrued) CalculateOrderTotals(IEnumerable<BagItems> bagItems, decimal discount)
        {
            decimal total = bagItems.Sum(p => p.Quantity * p.Product.Price);
            total = total > discount ? total - discount : 0;
            decimal tax = (bagItems.Sum(p => p.Quantity * p.Product.Price) / (100 + 20)) * 20;
            decimal subtotal = total - tax;
            decimal accrued = (1.0m / 100) * total;
            return (total, tax, subtotal, accrued);
        }
        private async Task<Order> CreateOrderAsync(OrderCreateDTO orderCreateDTO, int addressId, string userId, int orderPaymentId, decimal total, decimal tax, decimal subtotal)
        {
            Order order = new Order()
            {
                AddressId = addressId,
                Email = orderCreateDTO.Email,
                EmailUser = orderCreateDTO.EmailUser,
                FirstName = orderCreateDTO.FirstName,
                LastName = orderCreateDTO.LastName,
                OrderDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                PhoneNumber = orderCreateDTO.PhoneNumber,
                UserId = userId,
                OrderPaymentId = orderPaymentId,
                OrderTotal = total,
                Tax = tax,
                Subtotal = subtotal,
                Discount = orderCreateDTO.Discount,
            };
            await _orderRepository.InsertAsync(order);
            await _orderRepository.SaveAsync();
            return order;
        }
        private async Task UpdateUserAsync(User user, decimal discount, decimal accrued)
        {
            user.BagId = null;
            user.BonusBalance -= discount;
            user.BonusBalance += accrued;
            await _userManager.UpdateAsync(user);
        }
        private async Task CreateOrderItemsAsync(IEnumerable<BagItems> bagItems, int orderId)
        {
            foreach (var item in bagItems)
            {
                OrderItems orderItems = new OrderItems()
                {
                    Quantity = item.Quantity,
                    Name_en = item.Product.Name_en,
                    Name_uk = item.Product.Name_uk,
                    Name_es = item.Product.Name_es,
                    Name_fr = item.Product.Name_fr,
                    Description_en = item.Product.Description_en,
                    Description_uk = item.Product.Description_uk,
                    Description_es = item.Product.Description_es,
                    Description_fr = item.Product.Description_fr,
                    Price = item.Product.Price,
                    Size = item.Size,
                    Article = item.Product.Article,
                    ImagePath = item.Product.Images.OrderBy(img => img.Id).FirstOrDefault()?.ImagePath,
                    OrderId = orderId,
                    ProductId = item.ProductId,
                    Step = 0,
                    Status = "Order placed",
                };
                await _orderItemsRepository.InsertAsync(orderItems);
                await _orderItemsRepository.SaveAsync();
            }
        }
        private async Task ClearBagAsync(int bagId)
        {
            await _bagRepository.DeleteAsync(bagId);
            await _bagRepository.SaveAsync();
        }
        private async Task CreateUserBonusesAsync(string userId, int orderId, decimal discount, decimal accrued)
        {
            if (discount != 0)
            {

                UserBonuses bonuses_Redeemed = new UserBonuses()
                {
                    OrderDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    UserId = userId,
                    Name = orderId,
                    BonusesAccrued = discount,
                    BonusesDescription_en = "Purchase of goods",
                    BonusesDescription_uk = "Купівля товару",
                    BonusesDescription_es = "Compra de bienes",
                    BonusesDescription_fr = "Achat de biens",
                    BonusesOperation_en = "Redeemed",
                    BonusesOperation_uk = "Списання",
                    BonusesOperation_es = "Redimida",
                    BonusesOperation_fr = "Rachetée",
                };
                await _userBonuses.InsertAsync(bonuses_Redeemed);
                await _userBonuses.SaveAsync();
            }

            UserBonuses bonuses_Accrual = new UserBonuses()
            {
                OrderDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                UserId = userId,
                Name = orderId,
                BonusesAccrued = accrued,
                BonusesDescription_en = "Purchase bonus",
                BonusesDescription_uk = "Бонус за покупку",
                BonusesDescription_es = "Bono de compra",
                BonusesDescription_fr = "Bonus d'achat",
                BonusesOperation_en = "Accrual",
                BonusesOperation_uk = "Нарахування",
                BonusesOperation_es = "Devengo",
                BonusesOperation_fr = "Accumulation",
            };
            await _userBonuses.InsertAsync(bonuses_Accrual);
            await _userBonuses.SaveAsync();
        }
    }
}
