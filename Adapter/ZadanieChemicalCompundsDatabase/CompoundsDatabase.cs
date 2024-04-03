using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieChemicalCompundsDatabase
{
    public class CompoundsDatabase
    {
        private readonly Compounds _compound;

        public CompoundsDatabase(Compounds compound)
        {
            _compound = compound;
        }
        public string GetCompoundName()
        {
            return CompoundDatabaseValues.Names.First(c => c.CompoundID == (int)_compound).Value;
        }

        public string GetCompounFormula()
        {
            return CompoundDatabaseValues.Formulas.First(c => c.CompoundID == (int)_compound).Value;
        }

        public double GetCompoundMeltingPoint()
        {
            return CompoundDatabaseValues.MeltingPoints.First(c => c.CompoundID == (int)_compound).Value;
        }

        public double GetCompoundBoilingPoint()
        {
            return CompoundDatabaseValues.BoilingPoints.First(c => c.CompoundID == (int)_compound).Value;
        }
    }
}
