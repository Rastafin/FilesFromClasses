using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaFabryki
{
    internal class FactoryA : Factory
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("Rozpoczynam tworzenie produktu A");

            return new ProductA();
        }
    }
}
