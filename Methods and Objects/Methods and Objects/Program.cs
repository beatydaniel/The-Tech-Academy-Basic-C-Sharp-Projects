using System;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; // Employee class inherits from the Person class allowing me to use Person's properties
            employee.SayName(); //Calls the  superclass on the Employee Object
            Console.ReadLine();
        }
    }
}
