using Ardalis.Specification;
using Core.Entities.Category;

namespace Core.Specification
{
    public class MainCategorySpecification
    {
        public class All : Specification<MainCategory>
        {
            public All()
            {
                Query
                    .Include(c => c.SubCategories)
                    .ThenInclude(c => c.Categories);
            }
        }
    }
}
