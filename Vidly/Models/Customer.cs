using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        public bool IsSubcribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name="Memebership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Date of Birth")]
        public DateTime? Dob { get; set; }

    }
}