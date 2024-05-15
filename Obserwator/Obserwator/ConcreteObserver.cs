using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    internal class ConcreteObserver : Observer
    {
        public override void Update(Subject subject)
        {
            Console.WriteLine("{0}:{1} zaobserwowal zmiane w obiekcie {2}",
                this.GetType().Name,
                this.GetHashCode(),
                subject.GetType().Name);
        }
    }
}
