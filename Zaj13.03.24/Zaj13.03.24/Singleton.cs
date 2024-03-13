using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj13._03._24
{


    // nie posiada cechy treat safe
    internal class Singleton
    {
        private static Singleton? _instance;   // ta zmienna jest tworzona na poczatku startu programu i jest wpolna dla wszystkich instancji klasy
        
        public static Singleton GetInstance()
        {
            if(_instance == null)   // tutuaj czesto jest ten element wywolywany w wielu watkach i to wada tego wzorca, poniewaz moga zostac utworzone jednoczesnie instancje
            {
                _instance = new Singleton();
            }

            return _instance;
        }


        private Singleton()
        {
            Console.WriteLine("Instancja obiektu Singleton zostala utworzona");
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
