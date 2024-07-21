using Core.DTOs.UserProductReview;

namespace Core.Interfaces
{
    public interface IUserProductReviewService
    {
        Task AddUserProductReview(CreateUserProductReviewDTO createUserProductReviewDTO);
        Task<List<UserProductReviewDTO>> GetUserProductReview(int productId);
        Task <UserProductRatingDTO> GetUserProductRating(int productId);
    }
}