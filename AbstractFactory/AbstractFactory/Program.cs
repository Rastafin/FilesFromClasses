// See https://aka.ms/new-console-template for more information
using AbstractFactory;
using AbstractFactory.Creators;

Console.WriteLine("Hello, World!");

List<Client> clients = [
    new Client(new Factory1()),
    new Client(new Factory2())
    ];

foreach (var item in clients)
{
    item.Run();
}