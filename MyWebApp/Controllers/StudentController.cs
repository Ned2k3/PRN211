using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();
        public IActionResult Index(Student student)
        {
            //truyen du lieu sang view
            ViewBag.message = "hello";
            if (student.Code == null)
            {
                Student st = new Student("01", "Nguyen Van A", 9);
                ViewBag.student = st;
            }
            else
            {
                ViewBag.student = student;
            }
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                students.Add(student);
                return RedirectToAction("Index",student);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Update(string Code)
        {
            Student st = students.FirstOrDefault(x => x.Code == Code);
            students.Remove(st);
            return View(st);
        }

        [HttpPost]
        public IActionResult Update(Student st)
        {
            students.Add(st);
            return RedirectToAction("Index", st);
        }

        public IActionResult Delete(string Code)
        {
            Student st = students.FirstOrDefault(x => x.Code == Code);
            students.Remove(st);
            return RedirectToAction("Index",st);
        }
    }
}
