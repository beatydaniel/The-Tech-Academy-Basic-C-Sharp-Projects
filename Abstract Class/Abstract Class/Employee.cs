using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public class Employee : Person // Inheriting the Person class
    {
        public override void SayName() 
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); 
        }
    }
}
