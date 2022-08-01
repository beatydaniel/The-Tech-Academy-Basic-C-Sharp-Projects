using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphism_Submission
{
    public class Employee : Person, IQuittable //Adding the interface and Person class inheritance
    {
        public override void SayName() // Taking the abstract class Person and method SayName and adding a method to it.
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit() //Calling the quit method from my interface and adding a implementation of it.
        {
            Console.WriteLine("Are you sure you want to quit?"); ;
            Console.ReadLine();
        }
    }
}