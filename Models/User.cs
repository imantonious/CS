using System;
using System.ComponentModel.DataAnnotations;
using CSMVC.Validations;

namespace CSMVC.Models
{
    public class User
    {
        [Display(Name = "First Name: ")]
        [Required(ErrorMessage = "Enter your first name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        [Required(ErrorMessage = "Enter your last name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters.")]
        public string LastName { get; set; }

        [Display(Name = "Age: ")]
        [Required(ErrorMessage = "Enter your age.")]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers are allowed.")]
        public int age { get; set; }

        // [Required]
        // [MinLength(2)]
        // [Display(Name = "Your Username: ")]
        // public string UserName  { get; set; }

        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Enter your email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Enter your password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}