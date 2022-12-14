using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Employee
    {
        public virtual String Name { set; get; }
        public double Salary { set; get; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
