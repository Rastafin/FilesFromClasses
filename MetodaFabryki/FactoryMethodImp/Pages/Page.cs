using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImp.Pages
{
    internal abstract class Page
        (string title, string content, int pageIndex) : IPrintable
    {
        public string Title { get; set; } = title;
        public string Content { get; set; } = content;

        public int PageIndex { get; set; } = pageIndex;

        public virtual void Print()
        {
            Console.WriteLine("Strona: {0}, {1}, nr {2}",
                this.GetType().Name, this.Title, this.PageIndex);
        }
    }
}
