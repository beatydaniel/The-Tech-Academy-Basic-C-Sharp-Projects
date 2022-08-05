using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst_Final_Challenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student { Id = 0, FirstName = "Daniel", LastName = "Beaty" };
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}