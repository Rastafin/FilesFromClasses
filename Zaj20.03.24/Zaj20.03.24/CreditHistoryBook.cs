using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj20._03._24
{
    internal class CreditHistoryBook : IClientBook
    {
        private readonly Client _client;
        public bool IsValid()
        {
            Console.WriteLine("Sprawdzenie historii kredytowej dla klienta {0}" +
                " - {1} {2}", _client.Id, _client.Name, _client.SecondName);

            Console.WriteLine("Historia kredytowa - true");

            return true;    
        }

        public CreditHistoryBook(Client client)
        {
            _client = client;
        }
    }
}
