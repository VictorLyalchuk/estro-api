using AutoMapper;
using Core.DTOs.Bag_and_Order;
using Core.DTOs.Storage;
using Core.Entities.Bag_and_Order;
using Core.Entities.Product;
using Core.Interfaces;

namespace Core.Services
{
    public class AddressService : IAddressService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Address> _addressRepository;
        public AddressService(IMapper mapper, IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task CreateAsync(AddressDTO addressDTO)
        {
            var address = _mapper.Map<Address>(addressDTO);
            await _addressRepository.InsertAsync(address);
            await _addressRepository.SaveAsync();
        }

        public async Task<List<AddressDTO>> GetAllAddressAsync()
        {
            var address = await _addressRepository.GetAsync();
            return _mapper.Map<List<AddressDTO>>(address);
        }
    }
}
