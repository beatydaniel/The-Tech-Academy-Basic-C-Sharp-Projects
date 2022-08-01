using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphism_Submission
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Are you sure you want to quit?"); ;
            Console.ReadLine();
        }
    }
}