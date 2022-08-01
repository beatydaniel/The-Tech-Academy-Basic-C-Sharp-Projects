using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphism_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();

            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            Console.ReadLine();
            quittable.Quit();
        }
    }
}
