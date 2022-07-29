using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Integers
    {
        public void Integer(int number) // Using a void method it specifies that the method does not return a value.
        {
            int awnser = number / 2; 

            Console.WriteLine("\n" + number + " divided by 2 = " + awnser);
            Console.ReadLine();
        }
        public void Out(out int number2) // Using a out allows the number two variable to be called outside
        {
            number2 = 30;
            Console.WriteLine("\n" + number2 + " - This is using a Out in the method \n");
            Console.ReadLine();
        }

        public void Integer(int number3, int number4) // An overloaded method using two parameters
        {
            int awnser = (number3 / 2) + number4;
            Console.WriteLine("\n" + number3 + " divided by 2 " + " + " + number4 + " = " + awnser);
            Console.ReadLine();
        }
    }
}
