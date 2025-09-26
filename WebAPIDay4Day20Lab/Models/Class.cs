using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDay4Day20Lab.Models
{
    public class Class
    {
        [Key] // Primary Key
        public int ClassId { get; set; }

        [Required] // Not null
        [MaxLength(50)] // Max length of 50 characters
        public string ClassName { get; set; }

        [ForeignKey("Teacher")] // Foreign Key
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        // Many-to-Many relationship with Student entity
        public ICollection<Student> Students { get; set; }
    }
}
