using Core.DTOs.UserProductReview;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProductReviewController : Controller
    {
        private readonly IUserProductReviewService _review;
        public UserProductReviewController(IUserProductReviewService review)
        {
            _review = review;
        }
        
        [HttpPost("addReview")]
        public async Task<IActionResult> AddUserProductReview(CreateUserProductReviewDTO createUserProductReviewDTO)
        {
            await _review.AddUserProductReview(createUserProductReviewDTO);
            return Ok();
        }
        
        [HttpGet("getRating")]
        public async Task<IActionResult> GetUserProductRating(int productId)
        {
            var resutl = await _review.GetUserProductRating(productId);
            if (resutl == null)
            {
                return Ok();
            }
            return Ok(resutl);
        }
        
        [HttpGet("getReview/{productId}")]
        public async Task<IActionResult> GetUserProductReview(int productId, int page)
        {
            var resutl = await _review.GetUserProductReview(productId, page);
            if (resutl == null)
            {
                return Ok();
            }
            return Ok(resutl);
        }
        
        [HttpGet("getQuantityReview")]
        public async Task<IActionResult> GetQuantityUserProductReviewAsync(int productId)
        {
            var resutl = await _review.GetQuantityUserProductReviewAsync(productId);
            if (resutl == null)
            {
                return Ok();
            }
            return Ok(resutl);
        }
    }
}
