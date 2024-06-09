using Core.Entities.Product;

namespace Core.Interfaces
{
    public interface IInfoService
    {
        Task<List<Info>>? GetInfoAsync();
    }
}
