﻿using Core.DTOs.Filter;
using Core.DTOs.Product;

namespace Core.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDTO>?> GetProductByCategoryIdAsync(int id);
        Task<List<ProductDTO>>? GetProductByURLNameAsync(string urlName);
        Task<List<ProductDTO>>? FilterProductsAsync(FilterDTO? filterDTO);
        Task<List<ProductDTO>> GetProductByPageAsync(int page);
        Task<ProductDTO>? GetProductByIDAsync(int id);
        Task CreateAsync (CreateProductDTO createProductDTO);
        Task DeleteProductByIDAsync(int id);
        Task EditAsync(EditProductDTO editProductDTO);
        Task <int> ProductQuantity();
        Task <int> ProductQuantityByFiltersAsync(FilterDTO filterDTO);
    }
}
