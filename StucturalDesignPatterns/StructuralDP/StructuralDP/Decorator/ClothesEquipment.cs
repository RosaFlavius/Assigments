using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public class ClothesEquipment : IEquipment
    {
        public double GetCost()
        {
            return 120.5;
        }

        public string GetCategory()
        {
            return "Type of equipment: Clothes";
        }
    }
}
