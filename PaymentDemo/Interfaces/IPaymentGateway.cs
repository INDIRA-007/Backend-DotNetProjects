namespace PaymentDemo.Interfaces
{
    public interface IPaymentGateway
    {
        bool ProcessPayment(decimal amount);
    }
}
