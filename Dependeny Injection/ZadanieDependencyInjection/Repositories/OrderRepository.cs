using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDependencyInjection.Repositories
{
    internal class OrderRepository : IRepository
    {
        private List<Order> orders = new List<Order>();
        public void Add(Order item)
        {
            orders.Add(item);
        }

        public List<Order> GetAll()
        {
            return orders;
        }

        public void Remove(Order item)
        {
            orders.Remove(item);
        }
    }
}
