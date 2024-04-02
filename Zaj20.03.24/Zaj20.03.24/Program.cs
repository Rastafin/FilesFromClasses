namespace Zaj20._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1, "Imie", "Nazwisko");

            Console.WriteLine("Podaj zarobki");

            client.Earnings = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj kwote kredytu");

            client.RequestAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj oszczednosci");

            client.Savings = int.Parse(Console.ReadLine());

            client.IsValid();
        }
    }
}
