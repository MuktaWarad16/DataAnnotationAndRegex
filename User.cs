using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAnnotation_RegularExpression_PatternMatching
{
    internal class User
    {   
        [Required(ErrorMessage ="this is a mandatory field")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="length greater than 2")]
        public string Name { get; set; }

        [Required(ErrorMessage ="enter valid email id")]
        [EmailAddress(ErrorMessage ="enter valid email address")]
        public string Email {  get; set; }

        [Range(18,65)]
        public int Age {  get; set; }

    }
}
