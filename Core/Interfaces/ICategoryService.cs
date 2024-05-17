using Core.DTOs.Category;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<MainCategoryDTO>> MainGetAllAsync();
        Task<MainCategoryDTO?> MainGetByIdAsync(int id);
        Task<List<SubCategoryDTO>> SubGetAllAsync();
        Task<List<CategoryDTO>> GetAllAsync();
        Task<List<CategoryDTO>> CategoryGetWithSubAsync(string subName);
    }
}
