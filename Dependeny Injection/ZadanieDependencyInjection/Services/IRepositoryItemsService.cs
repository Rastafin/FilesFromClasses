using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDependencyInjection.Services
{
    public interface IRepositoryItemsService
    {
        void AddItemToRepo(Order order);
        void RemoveItemFromRepo(Order order);
        void DisplayItem();
    }
}
