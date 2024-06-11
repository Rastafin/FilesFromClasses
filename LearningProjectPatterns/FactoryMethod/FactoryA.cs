using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class FactoryA : Factory
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("Rozpoczecie tworzenia produktu A");
            return new ProductA();
        }
    }
}
