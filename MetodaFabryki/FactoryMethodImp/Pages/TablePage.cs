﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImp.Pages
{
    internal class TablePage(string title, string content, int pageIndex) : Page(title, content, pageIndex)
    {
    }
}
