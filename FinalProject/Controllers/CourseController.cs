using FinalProject.Models.DAO;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models.ServiceModel;

namespace FinalProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PRN211_FinalProjectContext context;
        private readonly DAO dao;

        public CourseController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = new PRN211_FinalProjectContext();
            dao = new DAO();
        }

        public IActionResult Index(int cateID)
        {
            if(cateID != 0)
            {
                Scategory? scategory = dao.GetCategoryById(cateID);
                var sublist = dao.GetSubCategoryList(cateID);
                if(scategory != null && sublist.Count != 0)
                {
                    ViewBag.categories = sublist;
                    return View();
                }
                else
                {
                    var courseList = dao.GetCourseListByCategory(cateID);
                    return View("~/Views/Course/Search.cshtml",courseList);
                }
            }
            else
            {
                var categories = dao.GetAllCourseCategory();
                ViewBag.categories = categories;
                return View();
            }
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string key)
        {
            key = key.Trim();
            var list = dao.GetCourseListBySearchKey(key);
            ViewBag.searchKey = key;
            ViewBag.count = list.Count;
            return View(list);
        }

        public IActionResult View(int cid)
        {
            Course? c = dao.GetCourseByID(cid);
            if(c == null) { return RedirectToAction("Home", "Home"); }
            ViewBag.schedule = Global.GetCoursePeriod();
            return View(c);
        }
    }
}
