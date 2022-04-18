using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentMethodContext
    {
        private IPaymentMethodStrategy _strategy;

        public void SeStrategy(IPaymentMethodStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PaymentMethod()
        {
            if (_strategy == null) Console.WriteLine("No strategy selected");
            else _strategy.PaymentMethod();
        } 
    }
}
