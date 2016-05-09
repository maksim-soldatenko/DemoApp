using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.DomainModel
{
    [Table("Instructors")]
    public class Instructor : Person
    {
        public DateTime HireDate { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
