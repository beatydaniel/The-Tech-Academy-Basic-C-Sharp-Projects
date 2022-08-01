using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    public class Employee
    {
        public int ID { get; set; } // My properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static bool operator == (Employee employee1, Employee employee2) // Creating a true or false bool using the == operator
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee employee1, Employee employee2) // Creating a true or false bool using the != operator
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}