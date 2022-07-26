using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");
            Console.WriteLine("What is your name?"); //Writes a Line in the program asking a question.
            string yourName = Console.ReadLine(); // Stores the typed string into the variable yourName
            Console.WriteLine("\nWhat course are you on?");
            string courseName = Console.ReadLine(); // Stores the typed string into the variable courseName 
            Console.WriteLine("\nWhat page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string strtrueFalse = Console.ReadLine();
            bool trueFalse = Convert.ToBoolean(strtrueFalse);
            Console.WriteLine("\nWere there any positve expreinces you'd like to share? Please be specific.");
            string positiveExperience = Console.ReadLine();// Stores the typed string into the variable positiveExpeirence
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();// Stores the typed string into the variable feedback
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudied = Console.ReadLine(); // Stores the typed string into the variable hoursStudied
            int hrs = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
