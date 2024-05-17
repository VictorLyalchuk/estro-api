using AutoMapper;
using Core.DTOs.Storage;
using Core.Entities.Product;
using Core.Interfaces;
using Core.Specification;

namespace Core.Services
{
    public class StorageService : IStorageService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<StorageEntity> _storageRepository;
        public StorageService(IMapper mapper, IRepository<StorageEntity> storageRepository)
        {
            _mapper = mapper;
            _storageRepository = storageRepository;
        }
        public async Task AddQuantityStorageAsync(StorageDTO [] storagesDTO)
        {
            var storages = _mapper.Map<StorageEntity[]>(storagesDTO);
            foreach (var storage in storages)
            {
                if(storage.ProductQuantity > 0)
                {
                    var existingStorage = await _storageRepository.GetByIDAsync(storage.Id);
                    if (existingStorage != null)
                    {
                        existingStorage.ProductQuantity += storage.ProductQuantity; 
                        existingStorage.inStock = true;

                        await _storageRepository.UpdateAsync(existingStorage);
                        await _storageRepository.SaveAsync();
                    }
                }
            }
        }
        public async Task CreateStorageForProduct(StorageDTO storageDTO)
        {
            var storage = _mapper.Map<StorageEntity>(storageDTO);
            await _storageRepository.InsertAsync(storage);
            await _storageRepository.SaveAsync();
        }
        public async Task<List<StorageDTO>> GetStorageByProductIdAsync(int productId)
        {
            var storages = await _storageRepository.GetListBySpec(new StorageSpecification.GetStorageByProductId(productId));
            return _mapper.Map<List<StorageDTO>>(storages);
        }

    }
}
