using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    internal class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }
        public void Update(ISubject subject)
        {
            if(subject is ConcreteSubject concreteSubject)
            {
                Console.WriteLine($"{_name} has received an update! New state: {concreteSubject.State}");
            }
        }
    }
}
