using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDependencyInjection.Repositories;

namespace ZadanieDependencyInjection.Services
{
    public class OrdersServiceByMethod : IRepositoryItemsServiceByMethod
    {
        private IRepository _repository;
        public void AddItemToRepo(Order order, IRepository repository)
        {
            _repository = repository;
            _repository.Add(order);
        }

        public void DisplayItem(IRepository repository)
        {
            _repository = repository;

            var orders = _repository.GetAll();
            foreach (var item in orders)
            {
                Console.WriteLine($"Order ID: {item.Id}, Description: {item.Content}");
            }
        }

        public void RemoveItemFromRepo(Order order, IRepository repository)
        {
            _repository = repository;

            _repository.Remove(order);
        }
    }
}
