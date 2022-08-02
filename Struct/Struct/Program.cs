using System;

namespace Struct
{
    class Program
    {
        public struct Number //This is a stuct
        {
            public decimal Amount; // Here i set its datatype to be a decimal

        }

        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 100.75m; // Here we can set the amount in decimal by using the struct

            Console.WriteLine("This is the amount = " + number.Amount);
            Console.ReadLine();
        }
    }
}
