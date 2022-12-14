using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant employee = new Accountant("Shehzad", "Ali", 1200);
            employee.customers = new string[] { "Shayan", "Asfand" };
            Console.WriteLine(employee.Name + " " + employee.Salary);
            
        }
    }
}
