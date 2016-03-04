using CreativeFactory.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativeFactory.Models
{
    public class Person
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is Required")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Display(Name = "Gender")]
        public Gender? Sex { get; set; }
        
    }
}