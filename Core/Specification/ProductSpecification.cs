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
            public FilterProducts(string subName, string urlName, FilterDTO? filterDTO)
            {
                List<string> Colors = new List<string>();
                List<string> Materials = new List<string>();
                List<int> Sizes = new List<int>();
                List<string> Purpose = new List<string>();
                int page = filterDTO.page;
                if (filterDTO.Color != null)
                {
                    Colors = filterDTO.Color;
                };
                if (filterDTO.Material != null)
                {
                    Materials = filterDTO.Material;
                };
                if (filterDTO.Size != null)
                {
                    Sizes = filterDTO.Size;
                };
                if (filterDTO.Purpose != null)
                {
                    Purpose = filterDTO.Purpose;
                };
                if (page < 1)
                {
                    page = 1;
                }
                int pageSize = 6;
                var query = Query.OrderBy(p => p.Id)
                     .Include(p => p.Images)
                     .Include(p => p.Category)
                     .Include(p => p.Storages)
                     .Where(p => p.Category.URLName == urlName);
                if (Colors.Any())
                {
                    query = query.Where(p => Colors.Contains(p.Color.ToLower()));
                }

                if (Materials.Any())
                {
                    query = query.Where(p => Materials.Contains(p.Material.ToLower()));
                }
                if (Sizes.Any())
                {
                    query = query.Where(p => p.Storages != null && p.Storages.Any(s => Sizes.Contains(s.Size) && s.inStock));
                }
                if (Purpose.Any())
                {
                    string value = Purpose[0];
                    query = query.Where(p => Purpose.Contains(p.Purpose.ToLower()));
                }
                var results = query.Skip((page - 1) * pageSize)
                     .Take(pageSize);
            }
        }
        public class ProductQuantityByFiltersAsync : Specification<ProductEntity>
        {
            public ProductQuantityByFiltersAsync(string subName, string urlName, FilterDTO? filterDTO)
            {
                List<string> Colors = new List<string>();
                List<string> Materials = new List<string>();
                List<int> Sizes = new List<int>();
                List<string> Purpose = new List<string>();
                if (filterDTO.Color != null)
                {
                    Colors = filterDTO.Color;
                };
                if (filterDTO.Material != null)
                {
                    Materials = filterDTO.Material;
                };
                if (filterDTO.Size != null)
                {
                    Sizes = filterDTO.Size;
                };
                if (filterDTO.Purpose != null)
                {
                    Purpose = filterDTO.Purpose;
                };
                var query = Query.OrderBy(p => p.Id)
                     .Include(p => p.Images)
                     .Include(p => p.Category)
                     .Include(p => p.Storages)
                     .Where(p => p.Category.URLName == urlName);
                if (Colors.Any())
                {
                    query = query.Where(p => Colors.Contains(p.Color.ToLower()));
                }

                if (Materials.Any())
                {
                    query = query.Where(p => Materials.Contains(p.Material.ToLower()));
                }
                if (Sizes.Any())
                {
                    query = query.Where(p => p.Storages != null && p.Storages.Any(s => Sizes.Contains(s.Size) && s.inStock));
                }
                if (Purpose.Any())
                {
                    query = query.Where(p => Purpose.Contains(p.Purpose.ToLower()));
                }
                var results = query;
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