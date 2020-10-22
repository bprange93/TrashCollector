using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Practice.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public  string Zipcode { get; set; }
        public string State  { get; set; }
        public double Balance { get; set; }
        public string PickUpDay { get; set; }
        public bool ConfirmedPickUp { get; set; }
        public DateTime ExtraPickUpDay { get; set; }
        public DateTime SuspendStart { get; set; }
        public DateTime SuspendEnd { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
