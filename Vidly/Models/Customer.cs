using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name ="Username")]
        public string Name { get; set; }

        [Required]
        public bool IsSubscribedToNewsletter { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; } 


        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

    }
}