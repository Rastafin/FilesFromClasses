using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj20._03._24
{
    internal class Client
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string SecondName { get; set; }

        public bool CreditHistory { get; set; }
        public int Earnings { get; set; }
        public int Savings { get; set; }
        public int RequestAmount { get; set; }

        public CreditHistoryBook CreditHistoryBook { get; set; }
        public EarningsBook EarningsBook { get; set; }
        public SavingsBook SavingsBook { get; set; }


        public Client(int id, string name, string secondName)
        {
            Id = id;
            Name = name;
            SecondName = secondName;

            CreditHistoryBook = new(this);
            EarningsBook = new(this);
            SavingsBook = new(this);
        }

        public bool IsValid()
        {
            Console.WriteLine("Sprawdzenie ogole dla klienta {0}" +
                " - {1} {2}", Id, Name, SecondName);

            var valid = CreditHistoryBook.IsValid()
                && EarningsBook.IsValid()
                && SavingsBook.IsValid();

            Console.WriteLine("Ocena ogolna - {0}", valid);

            return valid;
        }
    }
}
