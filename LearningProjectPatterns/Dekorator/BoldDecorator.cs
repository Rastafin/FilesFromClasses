using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    internal class BoldDecorator : Decorator
    {
        public BoldDecorator(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            return "<b>" + base.Operation() + "<b>";
        }
    }
}
