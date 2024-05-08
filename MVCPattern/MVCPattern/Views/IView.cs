using MVCPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Views
{
    internal interface IView <T> where T : IModel
    {
        void Display();

        void Display(T model);
    }
}
