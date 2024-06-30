using Ardalis.Specification;
using Core.Entities.Address;

namespace Core.Specification
{
    public class AddressSpecification
    {
        public class GettAllCity : Specification<CityEntity>
        {
            public GettAllCity()
            {
                Query.OrderBy(p => p.CityName)
                     .Include(p => p.Country);
            }
        }
        public class GettAllCountry : Specification<CountryEntity>
        {
            public GettAllCountry()
            {
                Query.OrderBy(p => p.CountryName);
            }
        }
    }
}
