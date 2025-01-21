using Microsoft.AspNetCore.Mvc;
using StudentAzure.Repositories;

namespace StudentAzure.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentRepository _repository;

        public StudentsController(StudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var students = _repository.GetAllStudents();
            return View(students);
        }
    }
}
