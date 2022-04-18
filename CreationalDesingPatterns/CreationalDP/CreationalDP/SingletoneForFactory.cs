using CreationalDP.Factories;
using CreationalDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP
{
    public class SingletoneForFactory
    {
        private static readonly Lazy<SingletoneForFactory> _instance = new Lazy<SingletoneForFactory>(() => new SingletoneForFactory());

        public SingletoneForFactory()
        {
        }

        public static SingletoneForFactory Instance
        {
            get
            {

                return _instance.Value;
            }
        }

        public void CreateQuote()
        {
            IQuoteFactory factory = null;

            Console.WriteLine("Quote sizes: shortQuote, midQuote, longQuote");
            string option = Console.ReadLine();

            switch (option)
            {
                case "shortQuote":
                    factory = new ShortQuoteFactory();
                    break;
                case "midQuote":
                    factory = new MidQuoteFactory();
                    break;
                case "longQuote":
                    factory = new LongQuoteFactory();
                    break;
            }

            IQuote message = factory.CreateQuote();
            Console.WriteLine(message.GetQuote());
        }
    }
}
