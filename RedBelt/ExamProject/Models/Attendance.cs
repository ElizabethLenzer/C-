using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class Attendance
    {
        [Key]

        public int AttendanceId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public int MeetupId { get; set; }

        public User User { get; set; }

        public Meetup Meetup { get; set; }
    }
}