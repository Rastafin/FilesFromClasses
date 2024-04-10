using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal abstract class Component
    {
        public string Name { get; set; }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract void Display(int depthLevel);

        public Component(string name)
        {
            Name = name;
        }
    }
}
