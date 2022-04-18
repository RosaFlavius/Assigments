using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public class ForFastRunning : EquipmentDecorator
    {
        public ForFastRunning(IEquipment equipment) : base(equipment)
        {
        }
        public override double GetCost()
        {
            return _equipment.GetCost() + 25;
        }

        public override string GetCategory()
        {
            return _equipment.GetCategory() + " running";
        }
    }
}
