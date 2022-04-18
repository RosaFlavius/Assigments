using Strategy;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select preference method of payment! 1 -> Visa; 2 -> Paypal; 3 -> Crypto");
            var selection = int.Parse(Console.ReadLine());

            var context = new PaymentMethodContext();

            if (selection == 1)
            {
                context.SeStrategy(new VisaMethodStrategy());
                context.PaymentMethod();
            }

            if (selection == 2)
            {
                context.SeStrategy(new PaypalMethodStrategy());
                context.PaymentMethod();
            }

            if (selection == 3)
            {
                context.SeStrategy(new CryptoMethodStrategy());
                context.PaymentMethod();
            }

            if (selection > 3 || selection < 1)
            {
                context.SeStrategy(new VisaMethodStrategy());
                context.PaymentMethod();
            }
        }
    }
}