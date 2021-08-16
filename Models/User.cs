using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "PW must b 8 characters!")]
        public string Password {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Guest> GuestRSVP {get; set;}
        public List<Wedding> AllWeddings {get; set;}

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPW {get; set;}

    }
}