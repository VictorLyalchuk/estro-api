using Core.DTOs.Bag_and_Order;

namespace Core.Interfaces
{
    public interface IFavoriteProductsService
    {
        Task AddFavoriteProduct(string userId, int productId);
        Task DeleteFavoriteProduct(string userId, int productId);
        Task <List<FavoriteProductDTO>> GetFavoriteProducts(string userId);
    }
}
