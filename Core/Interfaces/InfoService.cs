using Core.DTOs.Product;

namespace Core.Interfaces
{
    public interface IInfoService
    {
        Task<List<InfoDTO>>? GetInfoAsync();
    }
}
