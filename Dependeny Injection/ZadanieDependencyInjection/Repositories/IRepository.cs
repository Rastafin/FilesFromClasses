using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDependencyInjection.Repositories
{
    public interface IRepository
    {
        void Add(Order item);
        void Remove(Order item);
        List<Order> GetAll();
    }
}
