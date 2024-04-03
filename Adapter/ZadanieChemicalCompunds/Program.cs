using ZadanieChemicalCompundsDatabase;

namespace ZadanieChemicalCompunds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var components = new List<ChemicalCompound>()
            {
                new ChemicalCompound(5, "Metan", null, null, null),
                new DatabaseChemicalCompound(Compounds.WATER),
                new DatabaseChemicalCompound(Compounds.METHANOL),
                new DatabaseChemicalCompound(Compounds.ETHANOL),
                new DatabaseChemicalCompound(Compounds.BENZENE)
            };

            components.ForEach(compound => Console.WriteLine(compound.ToString()));
        }
    }
}
