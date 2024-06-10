using Core.DTOs.Bag_and_Order;

namespace Core.Interfaces
{
    public interface IAddressService
    {
        Task CreateAsync(AddressDTO addressDTO);
        Task<List<AddressDTO>> GetAllAddressAsync();
    }
}
