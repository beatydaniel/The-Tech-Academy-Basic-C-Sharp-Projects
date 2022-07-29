using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number to do a math operation: ");
            int num = Convert.ToInt32(Console.ReadLine()); // stores the users input

            Integers method = new Integers(); // Calls the Class Integers containing the methods.

            Console.WriteLine("\n"+ num + " + 100 = " + method.Add(num));
            Console.ReadLine();
            
            Console.WriteLine("\n"+ num + "- 50 = " + method.Subtraction(num));
            Console.ReadLine();
           
            Console.WriteLine("\n"+ num + " * 20 = " + method.Multiply(num));
            Console.ReadLine();

        }
    }
}
