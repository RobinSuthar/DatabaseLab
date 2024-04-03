
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLab
{
    public class Courses
    {
        [Required]
        [PrimaryKey]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Credit  { get; set; }

        public Courses() { }


        public override string ToString()
        {
            return $"CourseId:{CourseId,-8}" +
                $"Name:{Name,-45}" +
                $"Credit: {Credit}";
        }


    }
} 
