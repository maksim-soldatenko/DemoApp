using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.DAL;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
