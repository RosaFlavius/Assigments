using StructuralDP.Decorator;
using StructuralDP.Facede;
using StructuralDP.Proxy;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
      
        {
            IEquipment equipment = new ClothesEquipment();
            equipment = new ForFastRunning(equipment);

            IEquipment equipment2 = new ClothesEquipment();
            equipment2 = new ForFastRunning(equipment2);
            equipment2 = new ForMarathon(equipment2);

            Console.WriteLine($"Coffee1: {equipment.GetCategory()} for the price of {equipment.GetCost()}$");
            Console.WriteLine($"Coffee2: {equipment2.GetCategory()} for the price of {equipment2.GetCost()}$");


            Console.WriteLine();

            var service = new CryptoMineFacede();

            var bitcoin = new Crypto("bitcoin");

            var etherum = new Crypto("etherum");


            service.EldraGampaTesting(bitcoin);
            Console.WriteLine();
            service.EldraGampaTesting(etherum);

            var bp = new ProxyBonusProvider();
            bp.ListOfAllEmployee();
            bp.GiveBonus();

        }
    }
}