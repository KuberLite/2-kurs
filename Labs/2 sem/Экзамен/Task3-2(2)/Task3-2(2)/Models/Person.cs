using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2_2_.Models
{
    public class Person
    {
        [Key]
        public string Name { get; set; }

        public int CourseNumber { get; set; }

        public int Age { get; set; }
    }
}
