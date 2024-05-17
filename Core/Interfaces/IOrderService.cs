using Core.DTOs.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderCreateDTO orderCreateDTO);
        Task <List<OrderDTO>> GetAllOrdersAsync();
        Task <OrderDTO> GetOrderByEmailAsync(string email);
    }
}
