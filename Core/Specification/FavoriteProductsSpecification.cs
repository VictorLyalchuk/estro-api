using Ardalis.Specification;
using Core.Entities.Bag_and_Order;


namespace Core.Specification
{
    public class FavoriteProductsSpecification
    {
        public class GetbyUserId : Specification<FavoriteProduct>
        {
            public GetbyUserId(string userId)
            {
                Query
                    .Where(f => f.UserId == userId)
                    .Include(f => f.Product)
                    .ThenInclude(p => p.Images.OrderBy(i => i.Id))
                    .Include(p => p.Product)
                    .ThenInclude(p => p.Storages.OrderBy(i => i.Id));
            }
        }
        public class GetbyId : Specification<FavoriteProduct>
        {
            public GetbyId(string userId, int productId)
            {
                Query
                    .Where(f => f.UserId == userId && f.ProductId == productId)
                    .Include(f => f.Product)
                    .ThenInclude(p => p.Images);
            }
        }
    }
}
