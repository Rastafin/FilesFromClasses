using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : Target
    {
        private readonly Adaptee _adaptee = new ();
        public override void PrintInformation()
        {
            _adaptee?.Print();
        }
    }
}
