using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public class ForMarathon : EquipmentDecorator
    {
        public ForMarathon(IEquipment equipment) : base(equipment)
        {
        }
            public override double GetCost()
        {
            return _equipment.GetCost() + 167.5;
        }

        public override string GetCategory()
        {
            return _equipment.GetCategory() + " marathon";
        }
    }
    
}
