using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [MaxLength(10)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(10)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Compare("Email")]
        [DisplayName("Confirm Email Address")]
        public string ConfirmEmail { get; set; }

        [Required]
        [MinLength(8)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        [Compare("Password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Birthday")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(1, 10)]
        [DisplayName("Number of Tickets")]
        public int NumberOFTickets { get; set; }
    }
}