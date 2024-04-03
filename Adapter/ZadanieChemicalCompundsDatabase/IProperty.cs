using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieChemicalCompundsDatabase
{
    internal interface IProperty <T>
    {
        public int CompoundID { get; set; }
        public T Value { get; set; }

    }
}
