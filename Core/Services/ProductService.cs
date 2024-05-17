using AutoMapper;
using Core.DTOs.Filter;
using Core.DTOs.Image;
using Core.DTOs.Product;
using Core.DTOs.Storage;
using Core.Entities.Category;
using Core.Entities.Product;
using Core.Interfaces;
using Core.Specification;

namespace Core.Services
{
    public class ProductService : IProductService
    {
        private readonly int[] SIZEWOMEN = { 35, 36, 37, 38, 39, 40, 42 };
        private readonly int[] SIZEMEN = { 39, 40, 41, 42, 43, 44, 45, 46 };
        private readonly int Women = 1;
        private readonly int Men = 2;
        private readonly IMapper _mapper;
        private readonly IRepository<ProductEntity> _productRepository;
        private readonly IRepository<CategoryEntity> _categoryRepository;
        private readonly IRepository<StorageEntity> _storageRepository;
        private readonly IRepository<ImageEntity> _imageRepository;
        private readonly IFilesService _filesService;
        private readonly IImageService _imageService;
        public ProductService(IMapper mapper, IRepository<ProductEntity> productRepository, IRepository<CategoryEntity> categoryRepository, IFilesService filesService, IImageService imageService, IRepository<StorageEntity> storageRepository, IRepository<ImageEntity> imageRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _storageRepository = storageRepository;
            _imageRepository = imageRepository;
            _filesService = filesService;
            _imageService = imageService;
        }
        public async Task<List<ProductDTO>?> GetSomeByIdAsync(int id)
        {
            var products = await _productRepository.GetListBySpec(new ProductSpecification.Some(id));
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task<List<ProductDTO>>? GetProductByURLNameAsync(string urlName)
        {
            var products = await _productRepository.GetListBySpec(new ProductSpecification.GetProductByUrlName(urlName));
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task<List<ProductDTO>>? FilterProductsAsync(string subName, string urlName, FilterDTO? filterDTO)
        {
            var products = await _productRepository.GetListBySpec(new ProductSpecification.FilterProducts(subName, urlName, filterDTO));
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task<ProductDTO>? GetProductByIDAsync(int id)
        {
            var product = await _productRepository.GetItemBySpec(new ProductSpecification.GetMainCategory(id));
            return _mapper.Map<ProductDTO>(product);
        }
        public async Task<List<ProductDTO>> GetProductByPageAsync(int page)
        {
            var products = await _productRepository.GetListBySpec(new ProductSpecification.ProductByIdByPage(page));
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task CreateAsync(CreateProductDTO createProductDTO)
        {
            var product = _mapper.Map<ProductEntity>(createProductDTO);
            await _productRepository.InsertAsync(product);
            await _productRepository.SaveAsync();

            if (createProductDTO.ImagesFile != null)
            {
                foreach (var imageFile in createProductDTO.ImagesFile)
                {
                    var imageResult = await _imageRepository.GetByIDAsync(imageFile.Id);
                    var image = _mapper.Map<ImageDTO>(imageResult);
                    image.ProductId = product.Id;
                    image.ImagePath = imageFile.ImagePath;
                    await _imageService.EditAsync(image);
                };
            }
            var res = _productRepository.GetItemBySpec(new ProductSpecification.GetMainCategory(product.Id)).Result;
            if (res?.Category?.SubCategory?.MainCategoryId == Women)
            {
                foreach (var size in SIZEWOMEN)
                {
                    StorageEntity storage = new StorageEntity()
                    {
                        ProductId = res.Id,
                        Size = size,
                        ProductQuantity = 0,
                    };
                    await _storageRepository.InsertAsync(storage);
                    await _storageRepository.SaveAsync();
                }
            }
            else
            {
                foreach (var size in SIZEMEN)
                {
                    StorageEntity storage = new StorageEntity()
                    {
                        ProductId = res.Id,
                        Size = size,
                    };
                    await _storageRepository.InsertAsync(storage);
                    await _storageRepository.SaveAsync();
                }
            }
        }
        public async Task DeleteProductByIDAsync(int id)
        {
            var product = await _productRepository.GetItemBySpec(new ProductSpecification.ProductById(id));
            var imageClass = await _imageService.GetImageByIDProductAsync(id)!;
            if (imageClass != null)
            {
                foreach (var image in imageClass)
                {
                    await _filesService.DeleteProductImage(image.ImagePath!);
                }
                foreach (var image in imageClass)
                {
                    await _imageRepository.DeleteAsync(image.Id);
                    await _imageRepository.SaveAsync();
                }
            }
            var storages = await _storageRepository.GetListBySpec(new StorageSpecification.GetStorageByProductId(id));
            var res = _mapper.Map<List<StorageDTO>>(storages);
            if (res != null)
            {
                foreach (var storage in res)
                {
                    await _storageRepository.DeleteAsync(storage.Id);
                    await _storageRepository.SaveAsync();
                }
            }
            var productToDelete = await _productRepository.GetByIDAsync(id);
            if (productToDelete != null)
            {
                await _productRepository.DeleteAsync(productToDelete);
                await _productRepository.SaveAsync();
            }
        }
        public async Task EditAsync(EditProductDTO editProductDTO)
        {
            var product = _mapper.Map<ProductEntity>(editProductDTO);
            await _productRepository.UpdateAsync(product);
            await _productRepository.SaveAsync();

            if (editProductDTO.ImagesFile != null)
            {
                foreach (var imageFile in editProductDTO.ImagesFile)
                {
                    var imageResult = await _imageRepository.GetByIDAsync(imageFile.Id);
                    var image = _mapper.Map<ImageDTO>(imageResult);
                    image.ProductId = product.Id;
                    image.ImagePath = imageFile.ImagePath;
                    await _imageService.EditAsync(image);
                };
            }
        }
        public async Task<int> ProductQuantity()
        {
            var products = await _productRepository.GetAsync();
            return products.Count();
        }
        public async Task<int> ProductQuantityByFiltersAsync(string subName, string urlName, FilterDTO filterDTO)
        {
            var products = await _productRepository.GetListBySpec(new ProductSpecification.FilterProductsQuantity(subName, urlName, filterDTO));
            return products.Count();
        }
    }
}
