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
                    .Include(p => p.OrderItems)
                    .Include(p => p.Address);
            }
        }
        public class GetOrderByEmail : Specification<Order>
        {
            public GetOrderByEmail(string email, int page)
            {
                if (page < 1)
                {
                    page = 1;
                }
                int pageSize = 1;

                var query = Query.OrderBy(p => p.Id)
                     .Where(p => p.Email == email)
                     .Include(p => p.OrderItems)
                     .Include(p => p.Address);

                var result = query
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize);
            }
        }
        public class GetOrderCountByEmailSpecification : Specification<Order>
        {
            public GetOrderCountByEmailSpecification(string email)
            {
                Query.Where(p => p.Email == email);
            }
        }
    }
}