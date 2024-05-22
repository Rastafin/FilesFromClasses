using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection.Repositories
{
    internal interface IRepository
    {
        void Upload(string content);
        void Remove(string content);
        List<string> GetContentList();

    }
}
