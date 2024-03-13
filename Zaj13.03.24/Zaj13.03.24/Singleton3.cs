using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj13._03._24
{
    internal class Singleton3
    {
        private static Singleton3? _instance;
        private readonly static Object _lock = new();

        public static Singleton3 GetInstance()
        {
            lock (_lock)  // blokada kody dla konkretnego kodu, jesli jakis watek wejdzie do srodka i przejdzie przez locka to w tym samym czasie inny watek nie moze wejsc do locka
            {
                if (_instance == null)
                {
                    _instance = new Singleton3();
                }

                return _instance;
            }
        }

        private Singleton3()
        {
            Console.WriteLine("Instancja obiektu Singleton3 zostala utworzona");
        }
    }
}
