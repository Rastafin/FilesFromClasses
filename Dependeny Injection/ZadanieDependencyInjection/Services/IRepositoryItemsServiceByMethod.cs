using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDependencyInjection.Repositories;

namespace ZadanieDependencyInjection.Services
{
    public interface IRepositoryItemsServiceByMethod
    {
        void AddItemToRepo(Order order, IRepository repository);
        void RemoveItemFromRepo(Order order, IRepository repository);
        void DisplayItem(IRepository repository);
    }
}
