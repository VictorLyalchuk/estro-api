using Core.DTOs.Information;

namespace Core.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderCreateDTO orderCreateDTO);
        Task <List<OrderDTO>> GetAllOrdersAsync();
        Task<List<OrderDTO>> GetOrderByEmailAsync(string email, int page);
        Task<int> GetCountOrderByEmailAsync(string email);
    }
}
