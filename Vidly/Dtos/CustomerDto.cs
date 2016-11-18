﻿using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        public bool IsSubcribedToNewsletter { get; set; }


        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Dob { get; set; }
    }
}