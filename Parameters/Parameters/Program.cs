using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> name = new Employee<string>();
            name.things = new List<string> { "Daniel", "Brian", "Alex" };

            foreach (string thing in name.things)
            {
                Console.WriteLine(thing);
            }

            Employee<int> number = new Employee<int>();
            number.things = new List<int> { 1, 2, 3 };

            foreach (int thing2 in number.things)
            {
                Console.WriteLine(thing2);
            }
            Console.ReadLine();
        }
    }
}
