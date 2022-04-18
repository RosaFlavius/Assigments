using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student()
        {

        }
        public override string ToString()
        {
            return Name + " " + Age + " " + Grade;
        }

    }
}
