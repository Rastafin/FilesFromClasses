using AdapteeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class LibraryAdapter : Target
    {
        private readonly AdapteeLibrary.AdapteeLibrary _adaptee = new();

        public override void PrintInformation()
        {
            _adaptee.PrintToConsole();
        }
    }
}
