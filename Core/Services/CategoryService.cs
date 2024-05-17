using AutoMapper;
using Core.DTOs.Category;
using Core.Entities.Category;
using Core.Interfaces;
using Core.Specification;

namespace Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<MainCategory> _MainCategoryRepository;
        private readonly IRepository<SubCategory> _subCategoryRepository;
        private readonly IRepository<CategoryEntity> _categoryRepository;
        public CategoryService(IRepository<MainCategory> mainCategoryRepository, IRepository<CategoryEntity> categoryRepository, IMapper mapper, IRepository<SubCategory> subCategoryRepository)
        {
            _MainCategoryRepository = mainCategoryRepository;
            _subCategoryRepository = subCategoryRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<MainCategoryDTO>> MainGetAllAsync()
        {
            var categories = await _MainCategoryRepository.GetListBySpec(new MainCategorySpecification.All());
            //var categories = await _MainCategoryRepository.GetAsync(includeProperties: new[] { "Categories" });
            return _mapper.Map<List<MainCategoryDTO>>(categories);
        }
        public async Task<MainCategoryDTO?> MainGetByIdAsync(int id)
        {
            var category = await _MainCategoryRepository.GetByIDAsync(id);
            if (category != null)
            {
                return _mapper.Map<MainCategoryDTO>(category);
            }
            else
            {
                return null;
            }
        }
        public async Task<List<SubCategoryDTO>> SubGetAllAsync()
        {
            var categories = await _subCategoryRepository.GetListBySpec(new SubCategorySpecification.All());
            return _mapper.Map<List<SubCategoryDTO>>(categories);
        }
        public async Task<List<CategoryDTO>> GetAllAsync()
        {
            //var categories = await _categoryRepository.GetAsync();
            var categories = await _categoryRepository.GetListBySpec(new CategorySpecification.GetAllAsync());
            return _mapper.Map<List<CategoryDTO>>(categories);
        }
        public async Task<List<CategoryDTO>> CategoryGetWithSubAsync(string subName)
        {
            var categories = await _categoryRepository.GetListBySpec(new CategorySpecification.GetBySubNameAsync(subName));
            return _mapper.Map<List<CategoryDTO>>(categories);
        }
    }
}
