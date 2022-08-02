using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Assignment
{
    public class Employee
    {
        public Employee() : this("Daniel", "Beaty") //First Constructor using 'this' lets another Constructor use this if the parameters are left blank
        {
        }
        public Employee(string firstName, string lastName) // Second Constructor
        {
            fName = firstName;
            lName = lastName;
        }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}