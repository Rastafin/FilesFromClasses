using MVCPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Views
{
    internal class DataListSimpleView : IView<DataListModel>
    {

        public void Display()
        {
            Console.WriteLine("Brak danych do wyswietlenia");
        }

        public void Display(DataListModel model)
        {
            var dataView = new DataSimpleView();

            model.ForEach(dataView.Display);
        }
    }
}
