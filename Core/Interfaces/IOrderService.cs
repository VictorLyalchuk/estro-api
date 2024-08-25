using Core.DTOs.UserInfo;

namespace Core.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderCreateDTO orderCreateDTO);
        Task <List<OrderDTO>> GetAllOrdersAsync();
        Task<List<OrderDTO>> GetOrderByIdAsync(string Id, int page);
        Task<int> GetCountOrderByIdAsync(string Id);
        Task<List<OrderItemsDTO>> OrderByPageAsync(int page, int pageSize, int[] step);
        Task<int> OrderQuantityAsync(int[] step);
        Task EditOrderItemsAsync(OrderItemsDTO orderItemsDTO);
    }
}
