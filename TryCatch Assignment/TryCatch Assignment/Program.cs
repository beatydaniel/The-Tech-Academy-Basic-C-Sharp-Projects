using System;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0) // if the input is anything other than a whole number does this.
                {
                    throw new ExceptionClass(); //Instatiating the class
                }
                DateTime currentTime = DateTime.Now;
                int currentYear = currentTime.Year; //Takes the current times year and sets it
                int birthYear = currentYear - age; // takes the users input and subtracts it from the current year

                Console.WriteLine("You were born in:"+ birthYear); 
                Console.ReadLine();
            }
            catch (ExceptionClass)
            {
                Console.WriteLine("Please do not enter 0 or a negative number only whole numbers. ");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
                Console.ReadLine();
            }



        }
    }
}
