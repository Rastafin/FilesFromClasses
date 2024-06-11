using AdapterLearning;

IPayment paypalPayment = new PayPalPayment();
StripePaymentAdaptee stripePaymentAdaptee = new StripePaymentAdaptee();

IPayment paymentAdapter = new PaymentAdapter(stripePaymentAdaptee);

List<IPayment> paymentList = new List<IPayment>()
{
    paypalPayment,
    paymentAdapter
};

paymentList.ForEach(payment => payment.Pay(15));
