using ObserverImplementation.Documents;
using ObserverImplementation.Repositories;

var document = new Raport(1)
{
    Title = "Raport sprzedazy 2023",
    Content = "Tabele, liczby, wykresy, liczby, liczby ...",
};

var webRepository = new WebRepository(233);
var filerepository = new FileRepository(444);

document.AddToRepository(webRepository);
document.AddToRepository(filerepository);

var value = string.Empty;

while(value != "exit")
{
    Console.WriteLine(value);
    value = Console.ReadLine() ?? "Nieznany";
    document.Title = value;
}
