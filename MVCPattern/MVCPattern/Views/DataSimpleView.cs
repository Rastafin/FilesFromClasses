using MVCPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Views
{
    internal class DataSimpleView : IView<DataModel>
    {

        public void Display(DataModel model)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', 5),
                model?.Name ?? "nieznany");
            Console.WriteLine();
        }

        public void Display()
        {
            Console.WriteLine("Brak danych do wyswietlenia");
        }
    }
}
