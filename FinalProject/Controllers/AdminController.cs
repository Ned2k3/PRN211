using FinalProject.Models.DAO;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly DAO dao;

        public AdminController(ILogger<HomeController> logger)
        {
            dao = new DAO();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApproveAccount()
        {
            List<Account> list = dao.GetWaitingApproveAccount();
            return View(list);
        }

        public IActionResult ConfirmApprove(int id)
        {
            Account? acc = dao.GetAccountById(id);
            if (acc == null)
            {
                return RedirectToAction("ApproveAccount");
            }
            dao.ConfirmApprove(acc);
            return RedirectToAction("ApproveAccount");
        }

        public IActionResult ConfirmReject(int id)
        {
            Account? acc = dao.GetAccountById(id);
            if (acc == null)
            {
                return RedirectToAction("ApproveAccount");
            }
            dao.ConfirmReject(acc);
            return RedirectToAction("ApproveAccount");
        }

        public IActionResult MyCourse()
        {
            var list = dao.GetMyCourse();
            return View(list);
        }

        public IActionResult CourseDetail(int id) 
        { 
            Course? c = dao.GetCourseByID(id);
            return View(c);
        }
    }
}
