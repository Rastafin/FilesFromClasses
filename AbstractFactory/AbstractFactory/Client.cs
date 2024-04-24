using AbstractFactory.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client(Creators.AbstractFactory abstractFactory)
    {
        private readonly Creators.AbstractFactory _abstractFactory = abstractFactory;

        public void Run()
        {
            var productA = _abstractFactory?.CreateProductA();
            var productB = _abstractFactory?.CreateProductB();

            if(productA != null && productB != null)
            {
                productA.Interact(productB);
            }
    }
    }

    
}
