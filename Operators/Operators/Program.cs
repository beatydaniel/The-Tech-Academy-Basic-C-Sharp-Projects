using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", ID = 1234 };
            Employee employee1 = new Employee() { firstName = "Sample2", lastName = "Student2", ID = 1234};
            Console.WriteLine(employee.firstName + " " + employee.lastName+ " " + employee.ID);
            Console.WriteLine(employee1.firstName + " " + employee1.lastName +" " + employee1.ID);
            Console.ReadLine();

            if(employee == employee1)
            {
                Console.WriteLine("The IDs of the two employees are the same");
            }
            else
            {
                Console.WriteLine("The IDs are unique");
            }
        }
    }
}
