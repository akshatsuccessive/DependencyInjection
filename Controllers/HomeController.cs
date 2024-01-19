using Microsoft.AspNetCore.Mvc;
using MyDependencyInjection.Models;

namespace MyDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository _repository;

        //Initialize the variable through constructor (constructor injection)
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Index()
        {
            //StudentRepository repository = new StudentRepository();       // In order to get student data, the HomeController class depends on an instance of the StudentRepository class
            List<Student>? allStudentDetails = _repository?.GetAllStudent();
            return Json(allStudentDetails);
        }
        //[Route("{Id}")]
        public JsonResult GetStudentDetails(int Id)      // https://localhost:7041/Home/GetStudentDetails/1
        {
            //StudentRepository repository = new StudentRepository();
            Student? studentDetails = _repository?.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
/*
In the above example, the IoC container will automatically pass an instance of the StudentRepository to the constructor of 
HomeController. We don’t need to do anything else. 
An IoC container will create and dispose of an instance of the IStudentRepository based on the registered lifetime.
As we are injecting the dependency object through a constructor, it is called a constructor dependency injection.
*/

