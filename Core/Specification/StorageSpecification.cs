using Ardalis.Specification;
using Core.Entities.Product;

namespace Core.Specification
{
    public class StorageSpecification
    {
        public class GetStorageByProductId : Specification<StorageEntity>
        {
            public GetStorageByProductId(int id)
            {
                Query
                    .Where(p => p.ProductId == id);
            }
        }
    }
}
