using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CascadeDropdown.ViewModel
{
    public class UserRegistrationViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "The Name field does not accept symbol or digit.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email can not be blank")]
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        public string State { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and Confirm password do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [RegularExpression("^\\d{10}$")]
        public string MobileNumber { get; set; }

    }
}