using Core.Entities.Information;

namespace Core.Interfaces
{
    public interface IInfoService
    {
        Task<List<Info>>? GetInfoAsync(string subName);
    }
}
