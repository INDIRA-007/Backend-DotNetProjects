using PaymentDemo.Interfaces;

namespace PaymentDemo.Services
{
    public class PaymentService
    {
        private readonly IPaymentGateway _gateway;

        //constructor injection
        public PaymentService(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }
        public bool MakePayment(decimal amount)
        {
            return _gateway.ProcessPayment(amount);
        }
    }
}
