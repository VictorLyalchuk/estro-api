using Ardalis.Specification;
using Core.Entities.UserInfo;

namespace Core.Specification
{
    public class UserProductReviewSpecification
    {
        public class GetUserProductReview : Specification<UserProductReview>
        {
            public GetUserProductReview(int productId)
            {
                Query
                    .Where(f => f.ProductId == productId)
                    .OrderByDescending(f => f.OrderDate);
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
