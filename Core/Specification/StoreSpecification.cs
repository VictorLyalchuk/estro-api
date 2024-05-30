using Ardalis.Specification;
using Core.Entities.Store;

namespace Core.Specification
{
    public class StoreSpecification
    {
        public class StoreByPage : Specification<StoreEntity>
        {
            public StoreByPage(int page)
            {
                if (page < 1)
                {
                    page = 1;
                }
                int pageSize = 10;
                Query.OrderBy(p => p.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize);
            }
        }
    }
}
