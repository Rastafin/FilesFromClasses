using MVCPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Views
{
    internal class DataComplexView : IView<DataModel>
    {
        public void Display()
        {
            Console.WriteLine("Brak danych do wyswietlenia");
        }

        public void Display(DataModel model)
        {
            Console.Write("{0}{1}{0}",
                new string('-', 5),
                model?.Name ?? "nieznany");

            Console.WriteLine();
            Console.WriteLine("ID: {0}", model?.ID ?? "nieznany");
            Console.WriteLine("OPIS: {0}", model?.Description ?? "nieznany");
            Console.WriteLine();

        }
    }
}
