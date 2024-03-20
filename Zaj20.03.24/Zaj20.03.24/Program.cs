namespace Zaj20._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1, "Imie", "Nazwisko");

            Console.WriteLine("Podaj zarobki");

            int zarobki = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj oszczednosci");

            int oszczednosci = int.Parse(Console.ReadLine());
        }
    }
}
