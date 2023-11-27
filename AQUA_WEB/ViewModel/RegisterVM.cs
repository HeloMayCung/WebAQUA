using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AQUA_WEB.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Username cannot be black")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Username cannot be black")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username cannot be black")]
        [Compare("Password" , ErrorMessage ="Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email cannot be black")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        public string Moblie { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    }
}