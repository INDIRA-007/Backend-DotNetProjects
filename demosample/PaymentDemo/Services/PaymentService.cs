using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demosample.PaymentDemo.Services
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
