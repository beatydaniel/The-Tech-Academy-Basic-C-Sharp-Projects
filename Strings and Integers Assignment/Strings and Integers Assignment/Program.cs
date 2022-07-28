using System;
using System.Collections.Generic;

namespace Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 5, 6, 8 }; //list of integers

            try
            {
                Console.WriteLine("Enter a number to divide by: ");
                int numberOne = Convert.ToInt32(Console.ReadLine()); //stores the users input
                foreach (int i in numbers) //creates a loop for each of the items in the list
                {
                    int divide = i / numberOne; //Divides each item by the users input
                    Console.WriteLine(i + " divided by " + numberOne + " equals " + divide); //prints results
                }
            }
            catch(DivideByZeroException ex) // if the user typed 0 does this
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex) // if user types a string does this
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // any other error prints this
            {
                Console.WriteLine(ex.Message);
            }
            finally // alows to always run this even after a error
            {
                Console.ReadLine();
            }
        }
    }
}
