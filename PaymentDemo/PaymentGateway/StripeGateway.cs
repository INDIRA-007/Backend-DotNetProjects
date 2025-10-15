using PaymentDemo.Interfaces;

namespace PaymentDemo.PaymentGateway
{
    public class StripeGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount) => amount < 1000;
    }
}
