using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieChemicalCompundsDatabase
{
    internal class CompoundDatabaseValues
    {
        public static List<CompoundTextProperty> Names = new()
        {
            new CompoundTextProperty{CompoundID = (int) Compounds.WATER, Value = "Woda" },
            new CompoundTextProperty{CompoundID = (int) Compounds.METHANOL, Value = "Metanol" },
            new CompoundTextProperty{CompoundID = (int) Compounds.ETHANOL, Value = "Etanol" },
            new CompoundTextProperty{CompoundID = (int) Compounds.BENZENE, Value = "Benzen" },
        };

        public static List<CompoundTextProperty> Formulas = new()
        {
            new CompoundTextProperty{CompoundID = (int) Compounds.WATER, Value = "H20" },
            new CompoundTextProperty{CompoundID = (int) Compounds.METHANOL, Value = "CH4O" },
            new CompoundTextProperty{CompoundID = (int) Compounds.ETHANOL, Value = "C2H5OH" },
            new CompoundTextProperty{CompoundID = (int) Compounds.BENZENE, Value = "C6H6" },
        };

        public static List<CompoundNumericProperty> MeltingPoints = new()
        {
            new CompoundNumericProperty{CompoundID = (int) Compounds.WATER, Value = -100 },
            new CompoundNumericProperty{CompoundID = (int) Compounds.METHANOL, Value = -60 },
            new CompoundNumericProperty{CompoundID = (int) Compounds.ETHANOL, Value = -36 },
            new CompoundNumericProperty{CompoundID = (int) Compounds.BENZENE, Value = -120 },
        };

        public static List<CompoundNumericProperty> BoilingPoints = new()
        {
            new CompoundNumericProperty{CompoundID = (int) Compounds.WATER, Value = 100 },
            new CompoundNumericProperty{CompoundID = (int) Compounds.METHANOL, Value = 60 },
            new CompoundNumericProperty{CompoundID = (int) Compounds.ETHANOL, Value = 36 },
            new CompoundNumericProperty{CompoundID = (int) Compounds.BENZENE, Value = 120 },
        };
    }
}
