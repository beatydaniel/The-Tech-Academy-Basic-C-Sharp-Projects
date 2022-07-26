using System;

namespace Boolean_Logic_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int age = Convert.ToInt32(Age); //Converts the String into a integer
            Console.WriteLine("Have you ever had a DUI? \"true or false\"");
            string DUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(DUI);// Converts the string into a Boolean True or False 
            Console.WriteLine("How many speeding tickets do you have?");
            string Tickets = Console.ReadLine();
            int tickets = Convert.ToInt32(Tickets);

            bool age2 = age > 15; // asks if the age is greater than 15
            bool dui2 = dui == false; // asks if the dui is false
            bool tickets2 = tickets < 3; // asks if the tickets is no greater than 3
            bool Qualified = age2 && dui2 && tickets2; // asks if all are true or false

            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
