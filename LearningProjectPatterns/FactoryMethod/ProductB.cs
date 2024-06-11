using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ProductB : Product
    {
        public override string Print()
        {
            return $"Produkt: " + this.GetType();
        }
    }
}
