using Ardalis.Specification;
using Core.Entities.UserInfo;

namespace Core.Specification
{
    public class UserProductReviewSpecification
    {
        public class GetUserProductReview : Specification<UserProductReview>
        {
            public GetUserProductReview(int productId, int page)
            {
                if (page < 1)
                {
                    page = 1;
                }
                int pageSize = 5;
                var query = Query.OrderByDescending(p => p.OrderDate)
                     .Where(f => f.ProductId == productId);

                var result = query
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize);

            }
        }
        public class GetQuantityUserProductReview : Specification<UserProductReview>
        {
            public GetQuantityUserProductReview(int productId)
            {
                Query.Where(f => f.ProductId == productId);

            }
        }
        public class GetUserProductRating : Specification<UserProductReview>
        {
            public GetUserProductRating(int productId)
            {
                Query
                    .Where(f => f.ProductId == productId)
                    .OrderByDescending(f => f.OrderDate);
            }
        }
    }
}
