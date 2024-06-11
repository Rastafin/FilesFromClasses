using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal class Leaf : Component
    {
        public override string Operation()
        {
            return "Lisc";
        }
    }
}
