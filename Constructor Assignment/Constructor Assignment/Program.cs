using System;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Daniel Beaty";
            var program = "\"is using C#\"";
            Console.WriteLine(myName + " is a const string and can never change and " + "{0} is coming from a var instead of string", program);
            Console.ReadLine();

            Employee constuctor = new Employee(); //Instantiating  my class Person that has a chain constructor.

            Console.WriteLine(constuctor.fName + " " + constuctor.lName + ". This is coming from my constructor");
            Console.ReadLine();
        }
    }
}
