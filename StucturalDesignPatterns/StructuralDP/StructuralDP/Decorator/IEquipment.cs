using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public interface IEquipment
    {
        public double GetCost();
        public string GetCategory();
    }
}
