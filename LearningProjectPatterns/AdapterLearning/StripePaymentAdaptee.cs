using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    internal class StripePaymentAdaptee
    {
        public void MakeStripePayment(int amount)
        {
            Console.WriteLine($"\nPlatnosc Stripe: {amount}");
        }
    }
}
