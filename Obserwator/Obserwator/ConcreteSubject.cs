using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    internal class ConcreteSubject : Subject
    {
        private int id = 0;
        public int ID {
            get => id;
            set { id = value; this.Notify(); } 
        }
    }
}
