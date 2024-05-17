using Ardalis.Specification;
using Core.Entities.Information;


namespace Core.Specification
{
    public static class InfoSpecification
    {
        public class GetAll : Specification<Info>
        {
            public GetAll(string subName)
            {
                var query = Query
                    .Include(f => f.Options);

                //if (subName == "woman_shoes")
                //{
                //    query = query.Include(f => f.Options.Where(o => o.Id != 4));
                //}
                //else if (subName == "men_boots")
                //{
                //    query = (IIncludableSpecificationBuilder<Info, List<Options>?>)query.Include(f => f.Options.Where(o => o.Id != 3));

                //}
                var results = query;
            }
        }
    }
}
