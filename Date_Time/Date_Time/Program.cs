using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now; // Gets the Current Time
            Console.WriteLine(time); // Displays the Current Time
            Console.WriteLine("\n Please Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            DateTime addTime = time.AddHours(num); // Takes the input number and adds the number to the current time
            Console.WriteLine(addTime);
            Console.ReadLine();
        }
    }
}
