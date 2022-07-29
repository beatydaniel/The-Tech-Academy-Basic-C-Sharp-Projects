using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers method = new Integers();
            
            Console.WriteLine("Please Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            method.Integer(num);

            method.Out(out int number2); // calls the method and gets the value in the the method

            Console.WriteLine("Please Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter another number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
 
            method.Overload(num2, num3); // calls the method Overload which takes both the inputed integers

            Static.StaticClass(); //Calls my static method from my static class

            Console.ReadLine();
        }
    }
}
