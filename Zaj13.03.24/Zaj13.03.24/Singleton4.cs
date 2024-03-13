using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj13._03._24
{
    internal class Singleton4
    {
        private readonly static Lazy<Singleton4> _instance = new(() => new Singleton4());  // obiekt lazy jest bezpieczny miedzy watkami i sam dba o ten lazy inizialization

        public static Singleton4 GetInstance() { return _instance.Value; }

        private Singleton4()
        {
            Console.WriteLine("Instancja obiektu Singleton4 zostala utworzona");
        }
    }
}
