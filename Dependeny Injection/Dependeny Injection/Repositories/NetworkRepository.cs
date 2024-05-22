using Dependeny_Injection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection
{
    internal class NetworkRepository : IRepository
    {
        private readonly List<string> contentList = [];
        public void Upload(string content)
        {
            contentList.Add(content);

            Console.WriteLine("Dodano tresc do repo sieciowym");
        }

        public void Remove(string content)
        {
            contentList.Remove(content);

            Console.WriteLine("Usunieto tresc z repo sieciowego");
        }

        public List<string> GetContentList()
        {
            Console.WriteLine("Pobrano tresc z repo sieciowego");

            return contentList;
        }
    }
}
