using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CzescZajec
{
    internal class Class1 : BaseAbstractClass
    {
        public override void AbstractPrint()   
        {

            Console.WriteLine(new String('=', 20));
            Console.WriteLine("Metoda AbstractPrint() w klasie Class1" + this.GetType());
            Console.WriteLine(new String('=', 20));
        }
        //        vvv   tu na dole zamiast override dodajemy new i wtedy metoda jest przeslonieta
        public override void VirtualPrint()   // przeciazanie -> virtualna i abstrtakcyjna,     przyslanianie -> virtualna i standardowa
        {
            Console.WriteLine(new String('=', 20));
            Console.WriteLine("Metoda VirtualPrint() w klasie Class1" + this.GetType());
            Console.WriteLine(new String('=', 20));
        }

        public Class1():base(1, 2) { }

        public static void StaticPrint()
        {
            Console.WriteLine(new String('=', 20));
            Console.WriteLine("Metoda StaticPrint() w klasie Class1");   // nie mozna odwolywac sie do zmiennych niestatycznych poniewaz potrzebuja one instancji obiektu
            Console.WriteLine(new String('=', 20));                                       // a metoda statyczna nie moze miec instancji obiektu
        }
    }
}
