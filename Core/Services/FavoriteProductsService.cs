using AutoMapper;
using Core.DTOs.Bag_and_Order;
using Core.Entities.Bag_and_Order;
using Core.Entities.Product;
using Core.Entities.UserEntity;
using Core.Helpers;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Net;

namespace Core.Services
{
    public class FavoriteProductsService : IFavoriteProductsService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<FavoriteProduct> _favoriteProductsService;
        private readonly IRepository<ProductEntity> _productRepository;
        private readonly UserManager<User> _userManager;
        public FavoriteProductsService(IMapper mapper, IRepository<FavoriteProduct> favoriteProductsService, UserManager<User> userManager, IRepository<ProductEntity> productRepository)
        {
            _mapper = mapper;
            _favoriteProductsService = favoriteProductsService;
            _userManager = userManager;
            _productRepository = productRepository;
        }
        public async Task AddFavoriteProduct(string userId, int productId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.UserNotFoundByEmail, HttpStatusCode.NotFound);
            }

            var product = await _productRepository.GetByIDAsync(productId);
            if (product == null)
            {
                throw new CustomHttpException(ErrorMessages.ProductNotFound, HttpStatusCode.NotFound);
            }

            var favorite = new FavoriteProduct
            {
                UserId = userId,
                ProductId = productId
            };
            await _favoriteProductsService.InsertAsync(favorite);
            await _favoriteProductsService.SaveAsync();
        }

        public async Task DeleteFavoriteProduct(string userId, int productId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.UserNotFoundByEmail, HttpStatusCode.NotFound);
            }
            
            var favorite = await _favoriteProductsService.GetItemBySpec(new FavoriteProductsSpecification.GetbyId(userId, productId));
            if (favorite == null)
            {
                throw new CustomHttpException(ErrorMessages.ProductNotFound, HttpStatusCode.NotFound);
            }
            await _favoriteProductsService.DeleteAsync(favorite);
            await _favoriteProductsService.SaveAsync();
        }

        public async Task<List<FavoriteProductDTO>> GetFavoriteProducts(string userId)
        {
            var favorite = await _favoriteProductsService.GetListBySpec(new FavoriteProductsSpecification.GetbyUserId(userId));
            return _mapper.Map<List<FavoriteProductDTO>>(favorite);
        }
    }
}
