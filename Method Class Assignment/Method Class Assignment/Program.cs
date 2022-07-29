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

            method.Integer(first: 3, second: 5);  // Passing in two numbers and specifying the parameters

            Console.ReadLine();
        }
    }
}
