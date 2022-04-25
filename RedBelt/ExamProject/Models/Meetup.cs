using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamProject.Models
{
    public class Meetup
    {
        [Key]
        public int MeetupId { get; set; }
        // MeetUpTITLE
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be atleast 2 characters.")]
        [Display(Name = "MeetupTitle")]
        public string MeetupTitle { get;set; }
        // MeetUpDETAILS
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be atleast 2 characters.")]
        [Display(Name = "MeetupDetails")]
        public string MeetupDetails { get;set; }
        // MeetUpDATE
        [Required(ErrorMessage = "is required.")]
        [FutureDate]
        [Display(Name = "Date")]
        public DateTime MeetUpDate { get;set; }
        //MeetUpDURATION
        [Required(ErrorMessage ="is required.")]
        
        [Display(Name = "Duration")]
        
        public int MeetupDuration { get;set; }

        public DateTime CreatedAt { get;set; } = DateTime.Now;

        public DateTime UpdatedAt { get;set; } = DateTime.Now;

        /* Relationships */

        // Foreign Keys
        public int UserId { get;set; } 


        // // Navigation Properties (related class instances) - MUST use .Include to access.
        public User Author { get; set; }
        public List<Attendance> MeetupAttendees { get;set; } //The list of Users who are attending this Wedding
        public class FutureDateAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (((DateTime)value) <= DateTime.Today)
                {
                    return new ValidationResult("Only dates in the future are allowed!");
                }
                return ValidationResult.Success;
            }
        }
    }
}