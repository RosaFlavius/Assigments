using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfInhabitants { get; set; }

        public bool HasMoreThan20Towns { get; set; }

        public List<Town> hasTown { get; set; }


        public override string ToString()
        {
            return $"{Id} named as {Name} has {NumberOfInhabitants} ";
        }
    }

    public class Town 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfInhabitants { get; set; }
        public int NumberOfInstitutions { get; set; }
    }

    
}
