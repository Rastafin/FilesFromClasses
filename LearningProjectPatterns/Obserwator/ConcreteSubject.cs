using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    internal class ConcreteSubject : ISubject
    {
        private int _state;
        private List<IObserver> _observers = new List<IObserver>(); 

        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Notify();
            }
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
