using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj13._03._24
{

    // Nie posiada cechy lazy inizialization poniewaz jest wykonywana w przypadku uruchomienia programu (tworzona instancja jest an start programu)
    internal class Singleton2
    {
        private readonly static Singleton2 _instance = new Singleton2();

        public static Singleton2 GetInstance()
        {
            return _instance;
        }

        private Singleton2()
        {
            Console.WriteLine("Instancja obiektu Singleton2 zostala utworzona");
        }
    }
}
