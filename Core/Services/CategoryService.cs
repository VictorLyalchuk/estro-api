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
        private readonly IRepository<MainCategory> _mainCategoryRepository;
        private readonly IRepository<SubCategory> _subCategoryRepository;
        private readonly IRepository<CategoryEntity> _categoryRepository;
        private readonly IFilesService _filesService;
        public CategoryService(IRepository<MainCategory> mainCategoryRepository, IRepository<CategoryEntity> categoryRepository, IMapper mapper, IRepository<SubCategory> subCategoryRepository, IFilesService filesService)
        {
            _mainCategoryRepository = mainCategoryRepository;
            _subCategoryRepository = subCategoryRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _filesService = filesService;
        }

        public async Task<List<MainCategoryDTO>> MainGetAllAsync()
        {
            var categories = await _mainCategoryRepository.GetListBySpec(new MainCategorySpecification.All());
            return _mapper.Map<List<MainCategoryDTO>>(categories);
        }
        public async Task<List<SubCategoryDTO>> SubGetAllAsync()
        {
            var categories = await _subCategoryRepository.GetListBySpec(new SubCategorySpecification.All());
            return _mapper.Map<List<SubCategoryDTO>>(categories);
        }
        public async Task<List<CategoryDTO>> CategoryGetAllAsync()
        {
            var categories = await _categoryRepository.GetListBySpec(new CategorySpecification.GetAllAsync());
            return _mapper.Map<List<CategoryDTO>>(categories);
        }
        public async Task<List<CategoryDTO>> CategoryGetWithSubAsync(string subName)
        {
            var categories = await _categoryRepository.GetListBySpec(new CategorySpecification.GetBySubNameAsync(subName));
            return _mapper.Map<List<CategoryDTO>>(categories);
        }

        public async Task<List<MainCategoryDTO>> MainCategoryByPageAsync(int page)
        {
            var category = await _mainCategoryRepository.GetListBySpec(new CategorySpecification.MainCategoryByPageAsync(page));
            if (category != null)
            {
                return _mapper.Map<List<MainCategoryDTO>>(category);
            }
            else
            {
                return null;
            }
        }

        public async Task<MainCategoryDTO> GetMainCategoryByIdAsync(int id)
        {
            var category = await _mainCategoryRepository.GetByIDAsync(id);
            if (category != null)
            {
                return _mapper.Map<MainCategoryDTO>(category);
            }
            else
            {
                return null;
            }
        }

        public async Task<int> MainCategoryQuantityAsync()
        {
            var category = await _mainCategoryRepository.GetAsync();
            return category.Count();
        }

        public async Task CreateMainCategoryAsync(CreateMainCategoryDTO createMainCategoryDTO)
        {
            var category = _mapper.Map<MainCategory>(createMainCategoryDTO);
            await _mainCategoryRepository.InsertAsync(category);
            await _mainCategoryRepository.SaveAsync();
        }

        public async Task EditMainCategoryAsync(EditMainCategoryDTO editMainCategoryDTO)
        {
            var category = _mapper.Map<MainCategory>(editMainCategoryDTO);
            await _mainCategoryRepository.UpdateAsync(category);
            await _mainCategoryRepository.SaveAsync();
        }

        public async Task DeleteMainCategoryByIDAsync(int id)
        {
            var category = await _mainCategoryRepository.GetByIDAsync(id);
            if (category != null)
            {
                if (category.ImagePath != null)
                {
                    await _filesService.DeleteUserImageAsync(category.ImagePath!);
                }
                await _mainCategoryRepository.DeleteAsync(category);
                await _mainCategoryRepository.SaveAsync();
            }
        }
    }
}
