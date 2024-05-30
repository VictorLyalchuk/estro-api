using Core.DTOs.Store;

namespace Core.Interfaces
{
    public interface IStoreService
    {
        Task<List<StoreDTO>?> GetAllAsync();
        Task<List<StoreDTO>> GetAllByPageAsync(int page);
        Task<StoreDTO>? GetStoreByIDAsync(int id);
        Task CreateAsync(CreateStoreDTO createStoreDTO);
        Task DeleteAsync(int id);
        Task EditAsync(EditStoreDTO editStoreDTO);
    }
}
