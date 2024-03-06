namespace _2CzescZajec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstrackja - obiekt bazowy jest tylko wzorcem dla innych obiektow, nie da sie stworzyc instancji takiej klasy, metoda abstrakcyjna nie moze miec ciala
            // metody w klasie abstrakcyjnej sa tylko definicjami metod, ktore musza byc zaimplementowane w klasach potomnych

            Class1 class1 = new Class1();
            class1.AbstractPrint();  //metody ktore sa abstrakcyjne musza byc zaimplenetowane w ktorejs z klas potomnych

            List<BaseAbstractClass> baseAbstractClasses = [
                new Class1(),
                new Class2(1)
            ];

            baseAbstractClasses.ForEach(c =>
            {
                c.Print();
                c.VirtualPrint();
                c.AbstractPrint();
            });

            Class1 class1a = new Class1();
            BaseAbstractClass class1b = new Class1();

            class1.VirtualPrint();  // jesli przeslonimy (!) metode to wtedy wykona sie metoda zz takiej klasy jakiego zmienna jest typu
            class1b.VirtualPrint();  // a jesli jest metoda przeciazona to wtedy wykona sie zawsze typu szczegolowego




            Class1.StaticPrint();



            Console.ReadKey();
        }
    }
}
