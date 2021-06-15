using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class Student
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Rool No.")]
        public string RollNo { get; set; }

        [Display(Name = "Course")]
        public string Course { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }
    }
}
