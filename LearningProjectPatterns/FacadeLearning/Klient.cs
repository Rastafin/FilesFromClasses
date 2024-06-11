using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLearning
{
    internal class Klient
    {
        public static void WywolajFasade(Fasada fasada)
        {
            Console.WriteLine(fasada.Operacja());
        }
    }
}
