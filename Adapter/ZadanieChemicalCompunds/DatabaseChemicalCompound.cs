using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieChemicalCompundsDatabase;

namespace ZadanieChemicalCompunds
{
    //ADAPTER
    internal class DatabaseChemicalCompound : ChemicalCompound
    {
        private readonly CompoundsDatabase _compoundsDatabase;
        public DatabaseChemicalCompound(Compounds compound) : base((int) compound)
        {
            _compoundsDatabase = new(compound);

            this.Name = _compoundsDatabase.GetCompoundName();
            this.Formula = _compoundsDatabase.GetCompounFormula();
            this.MeltingPoint = _compoundsDatabase.GetCompoundMeltingPoint();
            this.BoilingPoint = _compoundsDatabase.GetCompoundBoilingPoint();
        }
    }
}
