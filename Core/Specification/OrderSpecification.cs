using Ardalis.Specification;
using Core.Entities.Information;

namespace Core.Specification
{
    public class OrderSpecification
    {
        public class GetAllOrders : Specification<Order>
        {
            public GetAllOrders()
            {
                Query
                    .Include(p => p.OrderItems);
                    //.Include(p => p.Users);
            }
        }
        public class GetOrderByEmail : Specification<Order>
        {
            public GetOrderByEmail(string email)
            {
                Query
                    .Where(p => p.Email == email)
                    .Include(p => p.OrderItems);
                    //.Include(p => p.Users);
            }
        }
    }
}
