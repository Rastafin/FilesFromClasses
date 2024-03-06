using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CzescZajec
{
    internal class Class2 : BaseAbstractClass
    {
        public override void AbstractPrint()   // override - przeciazenie metody
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Metoda AbstractPrint() w klasie Class2" + this.GetType());
            Console.WriteLine(new String('-', 20));

            // slowo base odnosci sie do instancji obiektu bazowego
        }

        public override void VirtualPrint()   // mozna tez przeciazyc metode ale musi ona byc virtual
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Metoda VirtualPrint() w klasie Class2" + this.GetType());
            Console.WriteLine(new String('-', 20));
        }

        // public override void Print()   -> taikej metody nie mozna przeciazyc bo ona jest standardowa

        public Class2(int x) : base(x, 2) { }
    }
}
