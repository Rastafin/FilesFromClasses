namespace Zajecia06._03._24
{
    internal class Program
    {
        //elementy statyczne sa uruchamiane podczas startu programu
        //elementy w klasie domyslnie sa prywatne, a w strukturze sa publiczne
        static void Main(string[] args)
        {
            var baseClass = new BaseClass();

            Class1 class1 = new Class1(); // typ danych klasy szczegolwej
            BaseClass class2 = new Class2(); // obiekt klasy bazowej

            // rzutowanie jest to zmiana typu ogolnego na typ szczegolowy ? v

            ((Class2)class2).PrintClass2();

            // klasy bazowe sa potrzebne aby moc wiele roznych typow klas umiescic w jednej kolekcji lub traktowac jako ten sam obiekt

            List<BaseClass> baseClasses = new List<BaseClass>()
            {
                class1, class2
        };

            baseClasses.ForEach(c =>
            {
                if(c.GetType() == typeof(Class1))
                {
                    ((Class1)c).PrintClass1();
                }   

                if(c is Class2)
                {
                    var c2 = (Class2)c;           // 2 przyklady skrocenia rzutowania
                    var c2b = c as Class2;

                    c2.PrintClass2();
                }
            });

            Console.ReadKey();
        }
    }
}
