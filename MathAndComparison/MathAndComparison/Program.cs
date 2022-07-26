using System;

namespace MathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("Hourly Rate: ");
            string hourlyrate = Console.ReadLine(); //stores the string
            int hrly = Convert.ToInt32(hourlyrate); //converts the string into a integer
            Console.WriteLine("Hours worked per week: ");
            string hours = Console.ReadLine();
            int hrs = Convert.ToInt32(hours);
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Hourly Rate: ");
            string hourlyrate2 = Console.ReadLine();
            int hrly2 = Convert.ToInt32(hourlyrate2);
            Console.WriteLine("Hours worked per week: ");
            string hours2 = Console.ReadLine();
            int hrs2 = Convert.ToInt32(hours2);

            int total1 = hrly * hrs; //Calculates the users inputs and multiplies them
            int Annual1 = total1 * 52;
            int total2 = hrly2 * hrs2;
            int Annual2 = total2 * 52; // Calculates the total and multiplies it by 52

            Console.WriteLine("Annual salary of Person 1: " + Annual1);
            Console.WriteLine("Annual salary of Person 2: " + Annual2);
            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            bool trueorFalse = Annual1 > Annual2; //Creates a True or False 
            Console.WriteLine(trueorFalse); //Calls the bool variable

        }
    }
}
