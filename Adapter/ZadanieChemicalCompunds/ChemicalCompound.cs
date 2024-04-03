using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieChemicalCompunds
{
    // TARGET
    internal class ChemicalCompound
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Formula { get; set; }
        public double? MeltingPoint { get; set; }
        public double? BoilingPoint { get; set; }

        public override string ToString()
        {
            return string.Format(@"
                Komponent chemiczny: {0}
                ---------------
                Wzór chemiczny: {1}
                Punkt topnienia: {2}
                Punkt wrzenia: {3}
                ", this.Name ?? "Nieznany", this.Formula ?? "Nieznany", this.MeltingPoint.HasValue ? this.MeltingPoint : "Nieznany", this.BoilingPoint.HasValue ? this.BoilingPoint : "Nieznany");
        }

        public ChemicalCompound(int id, string? name, string? formula, double? meltingPoint, double? boilingPoint)
        {
            ID = id;
            Name = name;
            Formula = formula;
            MeltingPoint = meltingPoint;
            BoilingPoint = boilingPoint;
        }

        protected ChemicalCompound(int id)
        {
            ID = id;
        }
    }
}
