using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    internal class ProductA1 : AbstractProductA
    {
        public override void Interact(IProduct product)
        {
            Console.WriteLine("Nastąpiła interakcja pmoiędzy obiektami: {0}, {1}", this.GetType().Name, product.GetType().Name);
        }
    }
}
