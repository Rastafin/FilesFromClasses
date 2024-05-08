using MVCPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Views
{
    internal class DataListComplexView : IView<DataListModel>
    {
        public void Display()
        {
            Console.WriteLine("Brak elementow na liscie do wyswietlenia");
        }

        public void Display(DataListModel model)
        {
            var dataView = new DataComplexView();

            model.ForEach(dataView.Display);
        }
    }
}
