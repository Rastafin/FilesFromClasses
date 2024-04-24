using FactoryMethodImp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodImp.Documents
{
    // Factory
    internal abstract class Document : IPrintable
    {
        public required string Title { get; set; } = null!;
        public List<Page> PageList { get; protected set; } = null!;

        protected abstract void CreatePages();

        public void Print()
        {
            Console.WriteLine("{0}{1}:\"{2}\"{0}", new string('-', 5), this.GetType().Name, this.Title);

            PageList.ForEach(page => page.Print());
        }

        public Document()
        {
            this.CreatePages();
        }
    }
}
