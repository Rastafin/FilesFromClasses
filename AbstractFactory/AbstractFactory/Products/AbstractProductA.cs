﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public abstract class AbstractProductA : IProduct
    {
        public abstract void Interact(IProduct product);
    }
}
