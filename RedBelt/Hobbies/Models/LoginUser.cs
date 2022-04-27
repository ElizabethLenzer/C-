using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// using Hobbies.Models.User;

namespace Hobbies.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "is required.")]
        // [Compare(User, ErrorMessage ="Must Be a Registered User")]
        public string LoginUsername { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "is required.")]
        [MinLength(8, ErrorMessage = "must be at least 8 characters")]
        [DataType(DataType.Password)] 
        public string LoginPassword { get; set; }
    }
}