using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;


namespace CodeFirst_Final_Challenge
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}
