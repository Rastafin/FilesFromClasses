using MVCPattern.Models;
using MVCPattern.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Controllers
{
    internal class DataController : IController
    {
        private DataModel GetDataModel(string id)
        {
            return new DataModel(id)
            {
                Name = "Model danych do wyswietlenia",
                Description = "to jest model numer 1",
                Type = "Model"
            };
        }

        private DataListModel GetListModel()
        {
            return new DataListModel("Lista A1")
            {
                new DataModel("M1")
                {
                    Name = "Model danych do wyswietlenia",
                    Description = "to jest model numer 1",
                    Type = "Model"
                },
                new DataModel("M2")
                {
                    Name = "Model danych do wyswietlenia 2",
                    Description = "to jest model numer 2",
                    Type = "Model"
                },
                new DataModel("M3")
                {
                    Name = "Model danych do wyswietlenia 3",
                    Description = "to jest model numer 3",
                    Type = "Inny Model"
                }
            };
        }

        public void DisplayComplexListView()
        {
            var model = GetListModel();

            var view = new DataListComplexView();

            view.Display(model);
        }

        public void DisplayComplexView(string id)
        {
            var model = GetDataModel(id);

            var view = new DataComplexView();

            view.Display(model);
        }

        public void DisplaySimpleListView()
        {
            var model = GetListModel();

            var view = new DataListSimpleView();

            view.Display(model);
        }

        public void DisplaySimpleView(string id)
        {
            //LOGIKA
            var model = GetDataModel(id);

            //PREZENTACJA
            var view = new DataSimpleView();
            view.Display(model);
        }
    }
}
