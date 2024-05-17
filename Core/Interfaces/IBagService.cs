using Core.DTOs.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBagService
    {
        Task CreateAsync(BagDTO bagDTO);
        Task DeleteBagByIdAsync(string email);
        Task<BagUserDTO>? GetBagByUserEmailAsync(string email);
        Task <int> GetCountBagByEmailAsync(string email);

        Task DeleteItemByID(int id);
        Task IncreaseAsync(int id);
        Task DecreaseAsync(int id);
    }
}
