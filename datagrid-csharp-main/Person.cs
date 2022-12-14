using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Array_Task_5
{
    class Person
    {
        public Person() { }
        public Person(String fName, String lname,String city)
        {
            this.FirstName = fName;
            this.LastName = lname;
            this.City = city;
        }
        public String FirstName
        {
            get;
            set;
        }
        public String LastName
        {
            get;
            set;
        }
        public String City
        {
            get;
            set;
        }
    }
}
