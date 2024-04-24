using FactoryMethodImp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImp.Documents
{
    internal class Report : Document
    {
        protected override void CreatePages()
        {
            this.PageList = [
                new TitlePage("Wzorce projektowe", "Fabryka", 1),
                new ContentPage("Teoria", "", 2),
                new ContentPage("Proaktyka", "", 3),
                new ContentPage("Implementacja", "", 4),
                new TablePage("Porownanie", "", 5),
                new ContentPage("Podsumowanie", "", 6)
                ];
        }
    }
}
