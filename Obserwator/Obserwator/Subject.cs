using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    internal abstract class Subject
    {
        private readonly List<Observer> _observers = [];
        public virtual void Attach(Observer observer)
        {
            if(observer != null)
            {
                _observers.Add(observer);
            }
        }

        public virtual void Detach(Observer observer)
        {
            if(observer != null)
            {
                _observers.Remove(observer);
            }
        }

        public virtual void Notify()
        {
            _observers.ForEach(observer => observer.Update(this));
        }
    }
}
