using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Facede
{
    public class CryptoMineFacede
    {
        public void EldraGampaTesting(Crypto crypto)
        {
            ComplexCryptoMineService service = new ComplexCryptoMineService(crypto);

            if (crypto.Type == "bitcoin")
            {
                service.Init();
                service.Validation();
                service.TestBitcoinMiningPowerWithEldra();
            }
            else if (crypto.Type == "etherum")
            {
                service.Init();
                service.Validation();
                service.TestEtherumMiningPowerWithGampa();
            }
            else
            {
                Console.WriteLine("Cannot test this type of crypto.");
            }
        }
    }
}
