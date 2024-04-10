using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component component)
        {
            Console.WriteLine("Nie mozna dodawac elementow do lisci");
        }

        public override void Display(int depthLevel)
        {
            Console.WriteLine(string.Format("{0}{1}", new string(' ', depthLevel), this.Name));
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Nie mozna usuwac elementow z lisci");
        }
    }
}
