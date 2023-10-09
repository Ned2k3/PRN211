using FinalProject.Models;
using FinalProject.Models.DAO;
using FinalProject.Models.ServiceModel;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class EnrollController : Controller
    {
        private readonly DAO dao;

        public EnrollController(ILogger<HomeController> logger)
        {
            dao = new DAO();
        }
        public IActionResult Index(int id)
        {
            Course? course = dao.GetCourseByID(id);
            if(course == null)
            {
                return View();
            }
            else
            {
                if(dao.isEnrolled(course.CourseId, Global.CurrentUser.AccountId) != null)
                {
                    return RedirectToAction("View","Course");
                }
                Account? creator = dao.GetCourseCreator(course.Creator);
                Scategory? cate = dao.GetCourseCategory(course.CategoryId);
                course.CreatorNavigation = creator;
                course.Category = cate;
            }
            return View(course);
        }

        [HttpPost]
        public IActionResult EnrollCourse(int cid)
        {
            Enroll enroll = new Enroll()
            {
                CourseId = cid,
                AccountId = Global.CurrentUser.AccountId,
                EntrollDate = DateTime.Now
            };
            dao.EnrollCourse(enroll);
            int newID = cid;
            return RedirectToAction("View", "Course", new {cid = newID});
        }
    }
}
