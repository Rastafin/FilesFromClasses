using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CzescZajec
{
    internal abstract class BaseAbstractClass
    {
        public void Print()
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("Metoda Print() w klasie BaseAbstractClass" + this.GetType());
            Console.WriteLine(new String('*', 20));
        }

        public abstract void AbstractPrint();

        public virtual void VirtualPrint()
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("Metoda VirtualPrint() w klasie BaseAbstractClass" + this.GetType());
            Console.WriteLine(new String('*', 20));
        }


        // w C# domyslnie konstruktor jest ukryty i jest nieparametryczny

        public BaseAbstractClass(int x, int y)
        {

        }
    }
}
