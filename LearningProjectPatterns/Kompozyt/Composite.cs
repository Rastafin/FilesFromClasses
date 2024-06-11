using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal class Composite : Component
    {
        private List<Component> _childComponents = new List<Component>();
        public override string Operation()
        {
            int i = 0;
            string result = "Galaz(";

            foreach(Component component in _childComponents)
            {
                result += component.Operation();

                if(i < _childComponents.Count - 1)
                {
                    result += " + ";
                }

                i++;
            }

            return result + ")";
        }

        public override void AddComponent(Component component)
        {
            _childComponents.Add(component);
        }

        public override void RemoveComponent(Component component)
        {
            _childComponents.Remove(component);
        }
    }
}
