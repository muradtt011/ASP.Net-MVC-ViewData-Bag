using ClassPractise.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassPractise.Controllers
{
    public class StudentController : Controller
    {

        private readonly List<Student> _students;

        public StudentController()
        {
            _students = new()
            {
                new() {Id=1, StudentName="Student1",GroupId=1},
                new() {Id=2, StudentName="Student2",GroupId=2},
                new() {Id=3, StudentName="Student3",GroupId=3},
                new() {Id=4, StudentName="Student4",GroupId=4},
                new() {Id=5, StudentName="Student5",GroupId=4},

            };
        }
        public IActionResult Index(int? Id)
        {
            if (Id == null) return View(_students);
            if(_students.Exists(s => s.GroupId == Id))
            {
                return View(_students.FindAll(s=> s.GroupId==Id));
            }
            return NotFound();
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return BadRequest();
            var existstudent=_students.Find(s=> s.Id==id);
            if (existstudent == null) return NotFound();
            return View(existstudent);

        }
    }
}
