using AutoMapper;
using Core.DTOs.Information;
using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Helpers;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Identity;


namespace Core.Services
{
    public class BagService : IBagService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Bag> _bagRepository;
        private readonly IRepository<BagItems> _bagItemsRepository;
        private readonly UserManager<User> _userManager;

        public BagService(IMapper mapper, IRepository<Bag> bagRepository, IRepository<BagItems> bagItemsRepository, UserManager<User> userManager)
        {
            _mapper = mapper;
            _bagRepository = bagRepository;
            _bagItemsRepository = bagItemsRepository;
            _userManager = userManager;
        }
        public async Task CreateAsync(BagDTO bagDTO)
        {
            try
            {
                var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(bagDTO.UserEmail));
                if (bag == null)
                {
                    var user = await _userManager.FindByEmailAsync(bagDTO.UserEmail);
                    if (user != null)
                    {
                        Bag newBag = new Bag()
                        {
                            CountProduct = 1,
                            OrderDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                            UserEmail = bagDTO.UserEmail,
                            UserId = user.Id,
                        };
                        await _bagRepository.InsertAsync(newBag);
                        await _bagRepository.SaveAsync();

                        await _bagItemsRepository.InsertAsync(new BagItems
                        {
                            ProductId = bagDTO.ProductId,
                            BagId = newBag.Id,
                            Quantity = 1,
                            Size = bagDTO.Size,
                        });
                        user.BagId = newBag.Id;
                        var result = await _userManager.UpdateAsync(user);
                    }
                }
                else
                {
                    bag.CountProduct += 1;
                    await _bagRepository.Update(bag);

                    bagDTO.Id = bag.Id;

                    var existBagItem = await _bagItemsRepository.GetItemBySpec(new BagItemsSpecification.GetBagItemByProps(bagDTO));
                    if (existBagItem == null)
                    {
                        await _bagItemsRepository.InsertAsync(new BagItems
                        {
                            ProductId = bagDTO.ProductId,
                            BagId = bagDTO.Id,
                            Quantity = 1,
                            Size = bagDTO.Size,
                        });
                    }
                    else
                    {
                        existBagItem.Quantity += 1;
                        await _bagItemsRepository.Update(existBagItem);
                    }
                };
                await _bagRepository.SaveAsync();
                await _bagItemsRepository.SaveAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task DeleteBagByIdAsync(string email)
        {
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(email));
            if (bag != null)
            {
                await _bagRepository.DeleteAsync(bag);
                await _bagRepository.SaveAsync();
            }
        }

        public async Task<BagUserDTO> GetBagByUserEmailAsync(string email)
        {
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(email));
            return _mapper.Map<BagUserDTO>(bag);
        }
        public async Task<int> GetCountBagByEmailAsync(string email)
        {
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(email));
            if (bag != null)
            {
                return bag.CountProduct;
            }
            else
                return 0;
        }


        // Bag Items
        public async Task DeleteItemByID(int id)
        {
            var bagItem = await _bagItemsRepository.GetByIDAsync(id);
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByItemsID(bagItem.BagId));
            if (bagItem != null && bag != null)
            {
                if (bag.CountProduct > bagItem.Quantity)
                {
                    bag.CountProduct -= bagItem.Quantity;
                    await _bagRepository.Update(bag);
                    await _bagItemsRepository.DeleteAsync(bagItem);
                    await _bagItemsRepository.SaveAsync();
                }

                else
                {
                    bag.CountProduct -= bagItem.Quantity;
                    await _bagRepository.DeleteAsync(bag);
                }
                var user = await _userManager.FindByEmailAsync(bag.UserEmail);
                if (user != null)
                {
                    user.BagId = null;
                    var result = await _userManager.UpdateAsync(user);
                }

            }

            await _bagRepository.SaveAsync();
        }
        public async Task IncreaseAsync(int id)
        {
            var bagItem = await _bagItemsRepository.GetByIDAsync(id);
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByItemsID(bagItem.BagId));
            if (bagItem != null && bag != null)
            {
                //if (bag.CountProduct > bagItem.Quantity)
                //{
                bag.CountProduct += 1;
                await _bagRepository.Update(bag);

                bagItem.Quantity += 1;
                await _bagItemsRepository.Update(bagItem);
                //}
                await _bagRepository.SaveAsync();
                await _bagItemsRepository.SaveAsync();
            }
        }
        public async Task DecreaseAsync(int id)
        {
            var bagItem = await _bagItemsRepository.GetByIDAsync(id);
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByItemsID(bagItem.BagId));
            if (bagItem != null && bag != null)
            {
                if (bagItem.Quantity > 1)
                {
                    bag.CountProduct -= 1;
                    await _bagRepository.Update(bag);

                    bagItem.Quantity -= 1;
                    await _bagItemsRepository.Update(bagItem);
                }
                await _bagRepository.SaveAsync();
                await _bagItemsRepository.SaveAsync();
            }
        }
    }
}
