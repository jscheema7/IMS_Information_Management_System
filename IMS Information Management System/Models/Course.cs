using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Course Name ")]
        public string CourseName { get; set; }

        [Display(Name = "Grade ")]
        public string Grade { get; set; }


        [Display(Name = "Duration ")]
        public string Duration { get; set; }


    }
}
