using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependeny_Injection.Repositories;

namespace Dependeny_Injection
{
    internal class DocumentService
    {
        private readonly IRepository _repository;
        public void AddDocumentToRepository(Document document)
        {
            _repository.Upload(document.Content);
        }

        public void RemoveDocumentFromRepository(Document document)
        {
            _repository.Remove(document.Content);
        }

        public void PrintDocumentInRepository()
        {
            _repository.GetContentList().ForEach(Console.WriteLine);
        }

        public DocumentService(IRepository repository)
        {
            ArgumentNullException.ThrowIfNull(repository);

            _repository = repository;
        }
    }
}
