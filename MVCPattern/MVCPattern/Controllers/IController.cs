using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Controllers
{
    internal interface IController
    {
        void DisplaySimpleView(string id);

        void DisplayComplexView(string id);

        void DisplaySimpleListView();

        void DisplayComplexListView();
    }
}
