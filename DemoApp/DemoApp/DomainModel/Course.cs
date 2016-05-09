using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.DomainModel
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
