using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Target
    {
        public virtual void PrintInformation()
        {
            Console.WriteLine("To jest metoda PrintInformation z klasy Target");
        }
    }
}
