using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers method = new Integers(); //Instantiating the class
            method.Integer(10, 20); // Passing in two numbers
            method.Integer(first: 3, second: 5);  // Specifying the parameters name and giving them a value

            Console.ReadLine();
        }
    }
}
