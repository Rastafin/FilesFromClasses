using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia06._03._24
{
    internal class BaseClass
    {
        //wlasciwosc rozni sie od zmiennej: wlasciwosc to prywatna zmienna ktora udostepnia publiczne metody do zmiany jej wartosci

        int x = 1;

        public int GetX() { return x; }
        public void SetX(int x) { this.x = x;}

        public int X { get; set; }


        int y = 0;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        private int z = 0;

        public int Z
        {
            get => z;
            set => z = value;
        }
    }
}
