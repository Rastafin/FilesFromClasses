using ObserverImplementation.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation.Repositories
{
    internal class WebRepository : Repository
    {
        public WebRepository(int id) : base(id)
        {
        }

        public override bool Update(Document document, DocumentEvents documentEvents)
        {
            switch (documentEvents)
            {
                case DocumentEvents.Added:
                    {
                        Console.WriteLine("Dokument {0}:\"{1}\" zostal wgrany do repozytorium sieciowego {2}", document.ID, document.Title, this.ID);
                        return true;
                    }
                case DocumentEvents.Removed:
                    {
                        Console.WriteLine("Dokument {0}:\"{1}\" zostal usuniety z repozytorium sieciowego {2}", document.ID, document.Title, this.ID);
                        return true;
                    }
                case DocumentEvents.Changed:
                    {
                        Console.WriteLine("Dokument {0}:\"{1}\" zostal zmieniony w repozytorium sieciowego {2}", document.ID, document.Title, this.ID);
                        return true;
                    }
            }

            return false;
        }
    }
}
