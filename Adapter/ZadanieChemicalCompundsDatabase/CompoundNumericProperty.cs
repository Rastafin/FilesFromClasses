﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieChemicalCompundsDatabase
{
    internal class CompoundNumericProperty : IProperty<double>
    {
        public int CompoundID { get; set; }
        public double Value { get; set; }
    }
}
