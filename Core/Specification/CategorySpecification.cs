using Ardalis.Specification;
using Core.Entities.Category;

namespace Core.Specification
{
    public static class CategorySpecification
    {
        public class GetAllAsync : Specification<CategoryEntity>
        {
            public GetAllAsync()
            {
                Query
                    .Include(c => c.SubCategory)
                    .ThenInclude(c => c.MainCategory);
                    //.OrderBy(c => c.Name)
                    //.Include(c => c.Products);
            }
        }
        public class GetAllAsyncByID : Specification<CategoryEntity>
        {
            public GetAllAsyncByID()
            {
                Query
                    .Include(c => c.Products)
                    //.ThenInclude(c => c.Images)
                    .OrderBy(c => c.Id);
            }
        }
        public class ByID : Specification<CategoryEntity>
        {
            public ByID(int ID)
            {
                Query
                    .Include(c => c.Products)
                    //.ThenInclude(c => c.Images)
                    .Where(c => c.Id == ID);
            }
        }
        public class GetBySubNameAsync : Specification<CategoryEntity>
        {
            public GetBySubNameAsync(string subName)
            {
                Query
                    //.ThenInclude(c => c.Images)
                    .Where(c => c.SubCategory.URLName == subName);
            }
        }

    }
}
