using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.DomainModel;

namespace DemoApp.DAL
{
    class SchoolContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> People { get; set; }

        public SchoolContext() : base("DemoSchoolContext")
        {
        }


    }
}
