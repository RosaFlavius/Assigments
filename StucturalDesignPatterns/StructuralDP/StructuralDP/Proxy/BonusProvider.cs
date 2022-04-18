using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Proxy
{
    public class BonusProvider : IBonusProvider
    {
        public void GetEmployee() { }

        private List<string> _employeeDatabase = new();

        public void ListOfAllEmployee()
        {
            foreach (var employee in _employeeDatabase)
            {
                Console.WriteLine($"{employee}\n");
            }
        }
        public void GiveBonus() { }

    }
}
