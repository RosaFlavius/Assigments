using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaypalMethodStrategy : IPaymentMethodStrategy
    {
        public void PaymentMethod()
        {
            Console.WriteLine("Payment: Paypal");
        }
    }
}
