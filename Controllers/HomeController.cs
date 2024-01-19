using Microsoft.AspNetCore.Mvc;
using MyDependencyInjection.Models;

namespace MyDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            StudentRepository repository = new StudentRepository();
            List<Student> allStudentDetails = repository.GetAllStudent();
            return Json(allStudentDetails);
        }
        //[Route("{Id}")]
        public JsonResult GetStudentDetails(int Id)      // https://localhost:7041/Home/GetStudentDetails/1
        {
            StudentRepository repository = new StudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
