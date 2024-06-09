using Ardalis.Specification;
using Core.DTOs.Filter;
using Core.Entities.Product;

namespace Core.Specification
{
    public class ProductSpecification
    {
        public class Some : Specification<ProductEntity>
        {
            public Some(int id)
            {
                Query
                    .Include(p => p.Images)
                    .Where(p => p.CategoryId == id);
            }
        }
        public class ProductById : Specification<ProductEntity>
        {
            public ProductById(int id)
            {
                Query
                    .Where(p => p.Id == id)
                    .Include(p => p.Images)
                    .Include(p => p.Category)
                    .Include(p => p.Storages);
            }
        }
        public class ProductByPage : Specification<ProductEntity>
        {
            public ProductByPage(int page)
            {
                if (page < 1)
                {
                    page = 1;
                }
                int pageSize = 10;
                Query.OrderBy(p => p.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .Include(p => p.Images)
                     .Include(p => p.Category)
                     .Include(p => p.Storages.OrderBy(s => s.Size));
            }
        }
        public class FilterProducts : Specification<ProductEntity>
        {
            public FilterProducts(FilterDTO? filterDTO)
            {
                List<string> Colors = filterDTO.Color ?? new List<string>();
                List<string> Materials = filterDTO.Material ?? new List<string>();
                List<int> Sizes = filterDTO.Size ?? new List<int>();
                List<string> Purpose = filterDTO.Purpose ?? new List<string>();
                int page = filterDTO.Page < 1 ? 1 : filterDTO.Page;
                string sort = filterDTO.Sort;
                int pageSize = filterDTO.ItemsPerPage;

                Query
                     .Include(p => p.Images)
                     .Include(p => p.Category)
                     .Include(p => p.Storages.OrderBy(p => p.Size));

                if (!string.IsNullOrEmpty(filterDTO.MainCategory))
                {
                    Query.Where(p => p.Category.SubCategory.MainCategory.URLName == filterDTO.MainCategory);
                }
                if (filterDTO.urlName != null)
                {
                    Query.Where(p => filterDTO.urlName.Contains(p.Category.URLName));
                }
                if (filterDTO.subName != null)
                {
                    Query.Where(p => filterDTO.subName.Contains(p.Category.SubCategory.URLName));
                }
                if (Colors.Any())
                {
                    Query.Where(p => Colors.Contains(p.Color.ToLower()));
                }
                if (Materials.Any())
                {
                    Query.Where(p => Materials.Contains(p.Material.ToLower()));
                }
                if (Sizes.Any())
                {
                    Query.Where(p => p.Storages != null && p.Storages.Any(s => Sizes.Contains(s.Size) && s.inStock));
                }
                if (Purpose.Any())
                {
                    Query.Where(p => Purpose.Contains(p.Purpose.ToLower()));
                }
                switch (sort)
                {
                    case "newest":
                        Query.OrderByDescending(p => p.Id);
                        break;
                    case "most_popular":
                        Query.OrderByDescending(p => p.OrderItems.GroupBy(oi => oi.ProductId).Select(g => g.Sum(oi => oi.Quantity)).Sum());
                        break;
                    case "price_low_to_high":
                        Query.OrderBy(p => p.Price);
                        break;
                    case "price_high_to_low":
                        Query.OrderByDescending(p => p.Price);
                        break;
                    default:
                        Query.OrderBy(p => p.Id);
                        break;
                }

                 Query.Skip((page - 1) * pageSize)
                     .Take(pageSize);
            }
        }
        public class ProductQuantityByFiltersAsync : Specification<ProductEntity>
        {
            public ProductQuantityByFiltersAsync(FilterDTO? filterDTO)
            {
                List<string> Colors = filterDTO.Color ?? new List<string>();
                List<string> Materials = filterDTO.Material ?? new List<string>();
                List<int> Sizes = filterDTO.Size ?? new List<int>();
                List<string> Purpose = filterDTO.Purpose ?? new List<string>();

                Query.OrderBy(p => p.Id)
                     .Include(p => p.Images)
                     .Include(p => p.Category)
                     .Include(p => p.Storages);

                if (!string.IsNullOrEmpty(filterDTO.MainCategory))
                {
                    Query.Where(p => p.Category.SubCategory.MainCategory.URLName == filterDTO.MainCategory);
                }
                if (filterDTO.urlName != null)
                {
                    Query.Where(p => filterDTO.urlName.Contains(p.Category.URLName));
                }
                if (filterDTO.subName != null)
                {
                    Query.Where(p => filterDTO.subName.Contains(p.Category.SubCategory.URLName));
                }
                if (Colors.Any())
                {
                    Query.Where(p => Colors.Contains(p.Color.ToLower()));
                }

                if (Materials.Any())
                {
                    Query.Where(p => Materials.Contains(p.Material.ToLower()));
                }
                if (Sizes.Any())
                {
                    Query.Where(p => p.Storages != null && p.Storages.Any(s => Sizes.Contains(s.Size) && s.inStock));
                }
                if (Purpose.Any())
                {
                    Query.Where(p => Purpose.Contains(p.Purpose.ToLower()));
                }
                var results = Query;
            }
        }
        public class GetMainCategory : Specification<ProductEntity>
        {
            public GetMainCategory(int id)
            {
                Query
                    .Where(p => p.Id == id)
                    .Include(p => p.Images)
                    .Include(p => p.Storages.OrderBy(s => s.Size))
                    .Include(p => p.Category)
                    .ThenInclude(p => p.SubCategory)
                    .ThenInclude(p => p.MainCategory);
            }
        }
        public class GetProductByUrlName : Specification<ProductEntity>
        {
            public GetProductByUrlName(string urlName)
            {
                Query
                    .Where(p => p.Category!.URLName == urlName)
                    .Include(p => p.Images)
                    .Include(p => p.Category)
                    .ThenInclude(p => p.SubCategory)
                    .ThenInclude(p => p.MainCategory);
            }
        }
    }
}