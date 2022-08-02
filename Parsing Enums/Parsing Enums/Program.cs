using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        public enum DaysOfTheWeek // Enum the Days of the Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturaday,
            Sunday
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter the current day of the week: "); //Asks the user to input the current Day of the week
                string input = Console.ReadLine();
                DaysOfTheWeek day; //Sets the value day to be used as the enum data type.
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input); // If the day is equal to the typed input do this
                Console.WriteLine(day + " - this result is coming from my enums"); // Prints the day enum from the resulted input.
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week. ");
                Console.ReadLine();
            }
        }
    }
}
