using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
         [Range(18,60,ErrorMessage = "The Age field must be between 18 and 60! ")]
        public int Age { get; set; }
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid, enter like # or #.##")] 
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public Char Sex { get; set; }

    }
}
