using Core.DTOs.UserInfo;

namespace Core.Interfaces
{
    public interface IAddressService
    {
        Task CreateAsync(AddressDTO addressDTO);
        Task<List<AddressDTO>> GetAllAddressAsync();
    }
}
