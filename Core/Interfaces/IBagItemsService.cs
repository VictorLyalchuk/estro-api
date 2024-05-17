using Core.DTOs.Information;
using Core.Entities.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBagItemsService
    {
        Task CreateAsync(BagItemsDTO bagDTO);
        Task EditAsync(BagItems bagItems);
        Task DeleteBagItemsByIdBagAsync(BagItems bagItems);
        Task DeleteItemByID(int id);
        Task<List<BagItemsDTO>>? GetBagItemsByBagIdAsync(int BagId);
        Task<List<BagItemsDTO>>? GetBagItemsByBagEmailAsync(string email);
    }
}
