using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Opertations method = new Opertations(); // Calls the Class Operations containing the methods.

            int awnser = method.Operation(300); // Using a integer and adding using the method
            Console.WriteLine(awnser + " - This is from the first method:" + " 300 + 10");
            Console.ReadLine();

            int awnser2 = method.Operation(300.5m); // Using a decimal and is converted using the method
            Console.WriteLine(awnser2 + " - This is from the second method:"+ " 300.5 * 25 ");
            Console.ReadLine();

            int awnser3 = method.Operation("300"); // Using a string and is converted using the method
            Console.WriteLine(awnser3 + " - This is from the third method:" + " \"300\"- 30");
            Console.ReadLine();
        }
    }
}
