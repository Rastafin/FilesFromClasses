using ZadanieDependencyInjection;
using ZadanieDependencyInjection.Services;

var order = new Order
{
    Id = 1,
    Content = "Order 1"
};

OrdersService orderService = new OrdersService()