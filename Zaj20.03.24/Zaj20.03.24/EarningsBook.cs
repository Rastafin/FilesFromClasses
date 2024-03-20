using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj20._03._24
{
    internal class EarningsBook : IClientBook
    {
        private readonly Client _client;
        public bool IsValid()
        {
            Console.WriteLine("Sprawdzenie zarobkow dla klienta {0}" +
                " - {1} {2}", _client.Id, _client.Name, _client.SecondName);

            var earnings = _client.Earnings >= 0.4 * _client.RequestAmount;

            Console.WriteLine("Zarobki - {0}", earnings);

            return earnings;
        }

        public EarningsBook(Client client)
        {
            _client = client;
        }
    }
}
