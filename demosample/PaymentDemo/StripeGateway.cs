using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demosample.PaymentDemo
{
    public class StripeGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount) => amount < 1000;
    }
}
