using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers method = new Integers();
            Console.WriteLine("Please Enter a Number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter a Second Number(Optional- Press Enter to leave blank): ");
            string stringNumber = Console.ReadLine();

            if (stringNumber == "") // if the value of the second input is blank do this
            {
                Console.WriteLine(numberOne + " + 20 " + " = " + method.Integer(numberOne));
                Console.ReadLine();
            }
            else // if there is two inputs of integers do this
            {
                int numberTwo = Convert.ToInt32(stringNumber);
                Console.WriteLine(numberOne + " + " + numberTwo + " = " + method.Integer(numberOne, numberTwo)); // if there are two numbers entered add them using the method integers
                Console.ReadLine();
            }  
        }
    }
}
