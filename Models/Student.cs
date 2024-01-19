using System.ComponentModel.DataAnnotations;

namespace MyDependencyInjection.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Branch { get; set; }
        public int Age { get; set; }   
    }
}
