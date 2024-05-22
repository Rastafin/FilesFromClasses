using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDependencyInjection.Repositories;

namespace ZadanieDependencyInjection.Services
{
    internal class OrderServiceByProperty : IRepositoryItemsService
    {
        public IRepository Repository { get; set; } = null!;
        public void AddItemToRepo(Order order)
        {
            Repository.Add(order);
        }

        public void DisplayItem()
        {
            var orders = Repository.GetAll();
            foreach (var item in orders)
            {
                Console.WriteLine($"Order ID: {item.Id}, Description: {item.Content}");
            }
        }

        public void RemoveItemFromRepo(Order order)
        {
            Repository.Remove(order);
        }
    }
}
