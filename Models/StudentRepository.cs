namespace MyDependencyInjection.Models
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> StudentsData()
        {
            return new List<Student>()
            {
                new Student() {StudentId  = 1, Name = "Akshat", Branch = "IT", Age = 21},
                new Student() {StudentId  = 2, Name = "Yash", Branch = "CSE", Age = 20},
                new Student() {StudentId  = 3, Name = "Bohra", Branch = "MCA", Age = 23},
                new Student() {StudentId  = 4, Name = "Govind", Branch = "SE", Age = 22},
                new Student() {StudentId  = 5, Name = "Prince", Branch = "ECE", Age = 24}
            };
        }
        public List<Student> GetAllStudent()
        {
            return StudentsData();
        }

        public Student GetStudentById(int StudentId)
        {
            return StudentsData().FirstOrDefault(s => s.StudentId == StudentId) ?? new Student();
        }
    }
}
