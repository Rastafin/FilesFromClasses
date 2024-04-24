using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public interface IProduct
    {
        void Interact(IProduct product);
    }
}
