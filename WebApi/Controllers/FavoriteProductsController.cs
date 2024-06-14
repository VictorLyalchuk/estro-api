using Core.DTOs.Bag_and_Order;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteProductsController : Controller
    {
        private readonly IFavoriteProductsService _favoriteProducts;
        public FavoriteProductsController(IFavoriteProductsService favoriteProducts)
        {
            _favoriteProducts = favoriteProducts;
        }
        [HttpPost("addFavorite")]
        public async Task<IActionResult> AddFavoriteProduct(CreateFavoriteProductDTO createFavoriteProductDTO)
        {
            await _favoriteProducts.AddFavoriteProduct(createFavoriteProductDTO.UserId, createFavoriteProductDTO.ProductId);
            return Ok();
        }

        [HttpDelete("deleteFavorite")]
        public async Task<IActionResult> RemoveFavoriteProduct(RemoveFavoriteProductDTO removeFavoriteProductDTO)
        {
            await _favoriteProducts.DeleteFavoriteProduct(removeFavoriteProductDTO.UserId, removeFavoriteProductDTO.ProductId);
            return Ok();
        }

        [HttpGet("getFavorite")]
        public async Task<IActionResult> GetFavoriteProducts(string userId)
        {
            var favorite = await _favoriteProducts.GetFavoriteProducts(userId);
            if(favorite == null)
            {
                return Ok();
            }
            return Ok(favorite);
        }
    }
}
