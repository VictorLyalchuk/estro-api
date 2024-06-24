using Ardalis.Specification;
using Core.Entities.Product;


namespace Core.Specification
{
    public static class InfoSpecification
    {
        public class GetAll : Specification<Info>
        {
            public GetAll()
            {
                Query
                    .Include(f => f.Options);
            }
        }
    }
}
