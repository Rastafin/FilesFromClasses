using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    internal class PayPalPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"\nPlatnosc Paypal: {amount}");
        }
    }
}
