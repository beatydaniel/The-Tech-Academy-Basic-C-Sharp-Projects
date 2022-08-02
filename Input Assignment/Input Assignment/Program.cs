using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\danis\Logs\log1.txt", true)) //Appends the input
            {
                file.WriteLine(num); // Adds the input number to file
            }
            string text;
            using(StreamReader file = new StreamReader(@"C:\Users\danis\Logs\log1.txt", true)) // Allows to read a file and display into the console.
            {
                text = file.ReadLine();
                Console.WriteLine("\n");
                while (text != null) // creates a loop to display all of the file data until there is none.
                {
                    Console.WriteLine(text);
                    text = file.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
