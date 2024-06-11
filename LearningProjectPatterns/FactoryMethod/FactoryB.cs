using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class FactoryB : Factory
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("Rozpoczecie tworzenia produktu B");
            return new ProductB();
        }
    }
}
