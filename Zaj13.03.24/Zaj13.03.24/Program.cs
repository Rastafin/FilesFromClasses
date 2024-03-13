namespace Zaj13._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //M1();
            //M2();
            //M3();
            //M4();
            //M5();
            M6();
        }

        static void M1()
        {
            var instance1 = new Class1();

            var instance2 = new Class1();

            instance1.X = 1;
            instance1.Y = 2;

            instance2.X = 3;
            instance2.Y = 4;

            Console.WriteLine(instance1.X);
            Console.WriteLine(instance1.Y);

            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());
        }

        static void M2()
        {
            Console.WriteLine("Wywolanie metody M2");

            var instance = Singleton.GetInstance();

            instance.X = 1;
            instance.Y = 2;

            var instance2 = Singleton.GetInstance();

            instance2.X = 3;
            instance2.Y = 4;

            Console.WriteLine(instance.X);
            Console.WriteLine(instance.Y);

            Console.WriteLine(instance.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());
        }

        static void M3()
        {
            Console.WriteLine("Wywolanie metody M3");

            for (int i = 0; i < 100; i++)
            {  // wyrazenie lambda
                Task.Run(() =>
                {
                    var instance = Singleton.GetInstance();
                });
            }
        }




        // Nie posiada cechy lazy inizialization poniewaz jest wykonywana w przypadku uruchomienia programu (tworzona instancja jest an start programu)
        static void M4()  // <- najwazniejszy jesli malo niformacji do przetwarzania, najczesniej sie go uzywa tutaj
        {
            Console.WriteLine("Wywolanie metody M4");

            for (int i = 0; i < 100; i++)
            {  
                Task.Run(() =>
                {
                    var instance = Singleton2.GetInstance();    // wszystko w tych klamerkach jest wykonywane w osobnym watku
                });
            }
        }

        static void M5()
        {
            Console.WriteLine("Wywolanie metody M5");

            for(int i = 0; i < 100; i++)
            {
                Task.Run(() =>
                {
                    var instance = Singleton3.GetInstance(); 
                });
            }
        }

        static void M6()
        {
            Console.WriteLine("Wywolanie metody M6");

            for (int i = 0; i < 100; i++)
            {
                Task.Run(() =>
                {
                    var instance = Singleton4.GetInstance();  // <- najwazniejszy 2
                });
            }
        }
    }
}
