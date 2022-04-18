using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public class EquipmentDecorator : IEquipment
    {
        protected IEquipment _equipment;

        public EquipmentDecorator(IEquipment equipment)
        {
            _equipment = equipment;
        }

        public virtual double GetCost()
        {
             return _equipment.GetCost();
        }


        public virtual string GetCategory()
        {
            return _equipment.GetCategory();
        }
    }
}
