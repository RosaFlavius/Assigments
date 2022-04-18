using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class VisaMethodStrategy : IPaymentMethodStrategy
    {
        public void PaymentMethod()
        {
            Console.WriteLine("Payment: Visa");
        }
    }
}
