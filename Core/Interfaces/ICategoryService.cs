using Core.DTOs.Category;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<MainCategoryDTO>> MainGetAllAsync();
        Task<List<SubCategoryDTO>> SubGetAllAsync();
        Task<List<CategoryDTO>> CategoryGetAllAsync();
        Task<List<CategoryDTO>> CategoryGetWithSubAsync(string subName);

        // Main Category CRUD
        Task <List<MainCategoryDTO>>MainCategoryByPageAsync(int page);
        Task<MainCategoryDTO> GetMainCategoryByIdAsync(int id);
        Task<int> MainCategoryQuantityAsync();
        Task CreateMainCategoryAsync(CreateMainCategoryDTO createMainCategoryDTO);
        Task EditMainCategoryAsync(EditMainCategoryDTO editMainCategoryDTO);
        Task DeleteMainCategoryByIDAsync(int id);
    }
}
