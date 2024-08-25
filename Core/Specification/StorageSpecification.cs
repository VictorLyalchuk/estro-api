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
                    .Where(p => p.ProductId == id)
                    .OrderBy(p => p.SortOrder);
            }
        }
        public class GetStorageByIdAsync : Specification<StorageEntity>
        {
            public GetStorageByIdAsync(int productId, string size)
            {
                Query.Where(p => p.ProductId == productId && p.Size == size);
            }
        }
    }
}
