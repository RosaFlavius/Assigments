using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Facede
{
    public class ComplexCryptoMineService
    {
        public Crypto crypto;

        public ComplexCryptoMineService(Crypto crypto)
        {
            this.crypto = crypto;
        }

        public void Init()
        {
            Console.WriteLine("Initialize service");
        }

        public void Validation()
        {
            Console.WriteLine("Checking crypto type");
            if (crypto.Type == "bitcoin")
            {
                Console.WriteLine("Service is ready for mining bitcoins!");
            }
            else if (crypto.Type == "etherum")
            {
                Console.WriteLine("Service is ready for mining etherums!");
            }
            else
            {
                Console.WriteLine("Unrecognised type...");
            }
        }

        public void TestBitcoinMiningPowerWithEldra()
        {
            if(crypto.Type != "bitcoin")
            {
                Console.WriteLine("Cannot test this type of crypto");
            }
            else
            {
                Console.WriteLine("Testing the bitcoin mining power with Eldra...");
            }
        }

        public void TestBitcoinMiningPowerWithVord()
        {
            if (crypto.Type != "bitcoin")
            {
                Console.WriteLine("Cannot test this type of crypto");
            }
            else
            {
                Console.WriteLine("Testing the bitcoin mining power with Vord...");
            }
        }

        public void TestEtherumMiningPowerWithBD()
        {
            if (crypto.Type != "etherum")
            {
                Console.WriteLine("Cannot test this type of crypto");
            }
            else
            {
                Console.WriteLine("Testing the etherum mining power with BD...");
            }
        }

        public void TestEtherumMiningPowerWithGampa()
        {
            if (crypto.Type != "etherum")
            {
                Console.WriteLine("Cannot test this type of crypto");
            }
            else
            {
                Console.WriteLine("Testing the etherum mining power with Gampa...");
            }
        }


        
    }
}
