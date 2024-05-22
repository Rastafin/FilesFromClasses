using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDependencyInjection.Repositories;

namespace ZadanieDependencyInjection.Services
{
    internal class OrdersService : IRepositoryItemsService
    {
        private readonly IRepository _repository;
        public OrdersService(IRepository repository)
        {
            _repository = repository;
        }

        public void AddItemToRepo(Order order)
        {
            _repository.Add(order);
        }

        public void DisplayItem()
        {
            var orders = _repository.GetAll();
            foreach (var item in orders)
            {
                Console.WriteLine($"Order ID: {item.Id}, Description: {item.Content}");
            }
        }

        public void RemoveItemFromRepo(Order order)
        {
            _repository.Remove(order)
        }
    }
}
