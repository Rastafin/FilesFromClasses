using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal abstract class Component
    {
        public abstract string Operation();
        public virtual void AddComponent(Component component)
        {
            Console.WriteLine("\nComponent cannot be added to leaf");
        }

        public virtual void RemoveComponent(Component component)
        {
            Console.WriteLine("\nComponent cannot be deleted from leaf");
        }
    }
}
