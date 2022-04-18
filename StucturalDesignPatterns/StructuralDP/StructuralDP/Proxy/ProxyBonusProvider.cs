using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Proxy
{
    public class ProxyBonusProvider : IBonusProvider
    {

        private BonusProvider _bonusProivder;
        public ProxyBonusProvider()
        {
            _bonusProivder = new BonusProvider();
        }

        public bool CheckContract()
        {
            
            string id = Console.ReadLine();

            if (id.Equals("bonusProvider") )
            {
                return true;
            }
            return false;
        }

        public void GetEmployee() {

            if (CheckContract())
            {
                _bonusProivder.GetEmployee();
            }
        }
        public void ListOfAllEmployee() {
            if (CheckContract())
            {
                _bonusProivder.ListOfAllEmployee();
            }
        }
        public void GiveBonus() {

            if (CheckContract())
            {
                _bonusProivder.GiveBonus();
            }
        }

    }
}
