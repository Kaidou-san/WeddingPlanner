using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner
{
    public class LoginUser
    { 
        [Required]
        [EmailAddress]
        public string LEmail {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "PW must b 8 characters!")]
        public string LPassword {get; set;}

    }
}