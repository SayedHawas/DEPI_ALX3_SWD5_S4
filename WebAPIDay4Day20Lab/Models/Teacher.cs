using System.ComponentModel.DataAnnotations;

namespace WebAPIDay4Day20Lab.Models
{
    public class Teacher
    {
        [Key] // Primary Key
        public int TeacherId { get; set; }

        [Required] // Not null
        [MaxLength(50)] // Max length of 50 characters
        public string Name { get; set; }

        [Required] // Not null
        [MaxLength(100)] // Max length of 30 characters
        public string Subject { get; set; }

        // Relationship with Class entity
        public ICollection<Class> Classes { get; set; }
    }
}
