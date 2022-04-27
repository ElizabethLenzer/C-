using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hobbies.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId{ get;set;}

        //Hobbiest Name
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = " must at least be 2 characters.")]
        [Display(Name = "HobbyName")]
        public string HobbyName { get;set;}

        //Hobby Details
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be atleast 2 characters.")]
        [Display(Name = "HobbyDetails")]
        public string HobbyDetails { get;set;}
        public DateTime CreatedAt { get;set;}
        public DateTime UpdatedAt { get;set;}

        public int UserId { get;set; } 


        // // Navigation Properties (related class instances) - MUST use .Include to access.
        public User Author { get; set; }
        public List<Attendance> HobbyAttendees { get;set; } //The list of Users who are attending this Wedding
    }
}