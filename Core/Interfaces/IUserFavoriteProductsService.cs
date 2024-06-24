using Core.DTOs.UserInfo;

namespace Core.Interfaces
{
    public interface IUserFavoriteProductsService
    {
        Task AddUserFavoriteProduct(string userId, int productId);
        Task DeleteUserFavoriteProduct(string userId, int productId);
        Task <List<UserFavoriteProductDTO>> GetUserFavoriteProducts(string userId);
    }
}
