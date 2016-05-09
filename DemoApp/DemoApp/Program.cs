using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.CommandInterceptors;
using DemoApp.DAL;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DbInterception.Add(new SchoolInterceptorLogging());
            var context = new SchoolContext();
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.FullName);
            }

            Console.ReadKey();
        }
    }
}
