using ObserverImplementation.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation.Repositories
{
    // Observer
    internal abstract class Repository(int id)
    {
        public int ID { get => id; }
        public abstract bool Update(Document document, DocumentEvents documentEvents);
    }
}
