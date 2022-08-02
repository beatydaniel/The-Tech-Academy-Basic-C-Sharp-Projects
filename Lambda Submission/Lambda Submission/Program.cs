using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() //Adding to Employee List
            {
                Id = 1,
                firstName = "Joe",
                lastName = "James"
            });
            employeeList.Add(new Employee()
            {
                Id = 2,
                firstName = "Joe",
                lastName = "Long"
            });
            employeeList.Add(new Employee()
            {
                Id = 3,
                firstName = "Rob",
                lastName = "Brown"
            });
            employeeList.Add(new Employee()
            {
                Id = 4,
                firstName = "Brian",
                lastName = "Manning"
            });
            employeeList.Add(new Employee()
            {
                Id = 5,
                firstName = "Kyle",
                lastName = "Bishop"
            });
            employeeList.Add(new Employee()
            {
                Id = 6,
                firstName = "Ashley",
                lastName = "Johnson"
            });
            employeeList.Add(new Employee()
            {
                Id = 7,
                firstName = "Kelly",
                lastName = "Patrick"
            });
            employeeList.Add(new Employee()
            {
                Id = 8,
                firstName = "Taylor",
                lastName = "Dark"
            });
            employeeList.Add(new Employee()
            {
                Id = 9,
                firstName = "Oslo",
                lastName = "Rock"
            });
            employeeList.Add(new Employee()
            {
                Id = 10,
                firstName = "Larry",
                lastName = "Bird"
            });
            Console.WriteLine("This is using a foreach Loop");

            List<Employee> joes = new List<Employee>();
            foreach (Employee name in employeeList) //Loops through the employee list and checks if any have the name Joe and if so adds to a new list and displays it
            {
                if (name.firstName == "Joe")
                {
                    joes.Add(name);
                }
            }
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.firstName +" "+ joe.lastName);
            }
            Console.ReadLine();

            Console.WriteLine("This is using a lambda expression");

            List<Employee> lambda = new List<Employee>();
            lambda = employeeList.Where(x => x.firstName == "Joe").ToList(); // Searchs the list in a  lambda expression collecting and creating a new value for each that has Joe in it.
            foreach(Employee x in lambda)
            {
                Console.WriteLine(x.firstName + " " + x.lastName);
            }
            Console.ReadLine();

            Console.WriteLine("This is using a lambda where it lists all the Employees ID are over 5"); 
            List<Employee> Ids = new List<Employee>();
            Ids = employeeList.Where(i => i.Id > 5).ToList();// lambda where Id of the employee list is greater than 5

            foreach (Employee i in Ids)
            {
                Console.WriteLine(i.firstName + " " + i.lastName);
            }
            Console.ReadLine();
        }
    }
}
