using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get; set;}
        [Required]
        public string WedderOne {get; set;}
        [Required]
        public string WedderTwo {get; set;}
        [Required]        
        public DateTime Date {get; set;}
        [Required]
        public string WeddingAddress { get; set; }
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public int UserId {get; set;}
        //navigation property
        public User MarriedCouple {get; set;}
        public List<Guest> GuestsWhoGoing {get; set;}
    }
}