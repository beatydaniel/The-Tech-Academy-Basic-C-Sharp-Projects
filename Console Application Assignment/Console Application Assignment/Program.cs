using System;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Number:"); //Asks the User to type in a Number
            string val = Console.ReadLine();
            int res = Convert.ToInt32(val); //Converts the string into a integer
            Console.WriteLine(val + " multiplied by 50 = "); //takes the string value and displays it in the console.
            int multiply = res * 50; // Using the now converted string thats now a integer I can multiply by another integer
            Console.WriteLine(multiply); // gets the results of the variable multiply
            Console.WriteLine("Input a Number:");
            string val2 = Console.ReadLine();
            int res2 = Convert.ToInt32(val2);
            Console.WriteLine(val2 + " plus 25 = ");
            int add = res2 + 25;
            Console.WriteLine(add);
            Console.WriteLine("Input a Number:");
            string val3 = Console.ReadLine();
            int res3 = Convert.ToInt32(val2);
            Console.WriteLine(val3 + " divided by 12.5 = ");
            int divide = res3 + 25;
            Console.WriteLine(divide);
            Console.WriteLine("Input a Number:");
            string val4 = Console.ReadLine();
            int res4 = Convert.ToInt32(val2);
            Console.WriteLine(val4 + " is > 50 ");
            bool trueOrFalse = res4 > 50;
            Console.WriteLine(trueOrFalse.ToString()); // Sees if the inputed value is greater than 50 if it is displays True
            Console.WriteLine("Input a Number:");
            string val5 = Console.ReadLine();
            int res5 = Convert.ToInt32(val2);
            Console.WriteLine(val5 + " divided by 7 ");
            int remainder = res5 % 7;  //Gets the remainder of the input number divided by 7
            Console.WriteLine(remainder);
        }
    }
}
