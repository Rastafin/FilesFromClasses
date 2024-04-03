using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieChemicalCompundsDatabase
{
    internal class CompoundTextProperty : IProperty<string>
    {
        public int CompoundID { get; set; }
        public required string Value { get; set; }
    }
}
