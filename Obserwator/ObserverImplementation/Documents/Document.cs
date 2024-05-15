using ObserverImplementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation.Documents
{
    // Subject
    internal abstract class Document(int id)
    {
        private string _title = null!;

        private string _content = null!;

        private readonly List<Repository> repositories = [];

        public int ID { get => id; }

        public string Title { get => _title; set { _title = value; this.NotifyAllRepositories(DocumentEvents.Changed); } }

        public string Content { get => _content; set { _content = value; this.NotifyAllRepositories(DocumentEvents.Changed); } }

        public virtual bool AddToRepository(Repository repository)
        {
            try
            {
                if(repository != null)
                {
                    repositories.Add(repository);

                    if(repository.Update(this, DocumentEvents.Added))
                    {
                        repositories.Add(repository);
                    }

                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }

            return false;
        }

        public virtual bool RemoveFromRepository(Repository repository)
        {
            try
            {
                if(repository != null)
                {
                    if(repository.Update(this, DocumentEvents.Removed))
                    {
                        repositories.Remove(repository);

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }

            return false;
        }

        public virtual void NotifyAllRepositories(DocumentEvents documentEvent)
        {
            repositories.ForEach(repository =>
            {
                try
                {
                    repository.Update(this, documentEvent);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                }
            });
        }
    }
}
