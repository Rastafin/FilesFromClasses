using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal class Composite : Component
    {
        private readonly List<Component> _components = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            if(component != null)
            {
                _components.Add(component);
            }
        }

        public override void Display(int depthLevel)
        {
            Console.WriteLine(string.Format("{0}/{1}/", new string(' ', depthLevel), this.Name));

            _components.ForEach(component => component.Display(depthLevel + this.Name.Length + 1));
        }

        public override void Remove(Component component)
        {
            if(component != null)
            {
                _components.Remove(component);
            }
        }
    }
}
