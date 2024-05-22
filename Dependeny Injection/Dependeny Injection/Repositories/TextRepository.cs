using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection.Repositories
{
    internal class TextRepository : IRepository
    {
        private readonly List<string> contentList = [];
        public void Upload(string content)
        {
            contentList.Add(content);

            Console.WriteLine("Dodano tresc do repo tekstowego");
        }



        public void Remove(string content)
        {
            contentList.Remove(content);

            Console.WriteLine("Usunieto tresc z repo tekstowego");
        }

        public List<string> GetContentList()
        {
            Console.WriteLine("Pobrano tresc z repo tekstowego");


            return contentList;          
        }
    }
}
