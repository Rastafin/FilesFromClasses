using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    internal class ItalicDecorator : Decorator
    {
        public ItalicDecorator(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            return "<i>" + base.Operation() + "<i>";
        }
    }
}
