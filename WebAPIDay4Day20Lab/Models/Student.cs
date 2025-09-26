using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDay4Day20Lab.Models
{
    //[Table("TblStudents")]
    public class Student
    {
        [Key] // Primary Key
        public int StudentId { get; set; }

        [Required] // Not null
        [MaxLength(50)] // Max length of 50 characters
        public string Name { get; set; }

        [DataType(DataType.Date)] // Data type as Date
        public DateTime EnrollmentDate { get; set; }

        [NotMapped] // This property will not be mapped to the database
        public int Age { get; set; }

        // Relationship with Class entity
        public ICollection<Class> Classes { get; set; }
    }
}
