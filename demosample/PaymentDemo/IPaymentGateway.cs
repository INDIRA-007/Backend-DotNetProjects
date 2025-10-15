using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demosample.PaymentDemo
{
    public interface IPaymentGateway
    {
        bool ProcessPayment(decimal amount);
    }
}
