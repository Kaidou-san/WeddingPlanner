using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int GuestId {get; set;}
        public int UserId {get; set;}
        public int WeddingId {get; set;}
        //navigation properties
        public User User {get; set;}
        public Wedding Wedding {get; set;}
    }
}