using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Accountant : Employee
    {
        public override String Name { set; get; }
        public string[] customers { set; get; }

        public Accountant(string name, string otherName, double salary) : base(otherName, salary)
        {
            Name = name;
        }
    }
}
