using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    internal class PaymentAdapter : IPayment
    {
        private readonly StripePaymentAdaptee _stripePaymentAdaptee;

        public PaymentAdapter(StripePaymentAdaptee stripePaymentAdaptee)
        {
            _stripePaymentAdaptee = stripePaymentAdaptee;
        }

        public void Pay(int amount)
        {
            _stripePaymentAdaptee.MakeStripePayment(amount);
        }
    }
}
