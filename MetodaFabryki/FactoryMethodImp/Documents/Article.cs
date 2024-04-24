using FactoryMethodImp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImp.Documents
{
    internal class Article : Document
    {
        protected override void CreatePages()
        {
            this.PageList = [
                new TitlePage("Wzorce projektowe - ewaluacja za", "Fabryka", 1),
                new ContentPage("Teoria", "", 2),
                new TablePage("Oceny", "", 3),
                new TablePage("Aktywnosc", "", 4),
                new TablePage("Porownanie", "", 5),
                new ContentPage("Lista obecnosci", "", 6),
                new ContentPage("Podsumowanie", "", 7)
                ];
        }
    }
}
