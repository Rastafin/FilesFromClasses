using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj20._03._24
{
    internal class SavingsBook : IClientBook
    {
        private readonly Client _client;
        public bool IsValid()
        {
            Console.WriteLine("Sprawdzenie oszczednosci dla klienta {0}" +
                " - {1} {2}", _client.Id, _client.Name, _client.SecondName);

            var savings = _client.Savings >= 3 * _client.Earnings;

            Console.WriteLine("Oszczednosci - {0}", savings);

            return savings;
        }

        public SavingsBook(Client client)
        {
            _client = client;
        }
    }
}
