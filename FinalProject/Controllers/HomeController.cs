using FinalProject.Models;
using FinalProject.Models.DAO;
using FinalProject.Models.ServiceModel;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PRN211_FinalProjectContext context;
        private readonly DAO dao;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = new PRN211_FinalProjectContext();
            dao = new DAO();
        }

        public IActionResult Home()
        {
            if (Global.CurrentUser != null)
            {
                var categories = context.Scategories.Select(c => new
                {
                    Name = c.CategoryName,
                    ID = c.CategoryId,
                    SubID = c.SubCategoryOf,
                    Subcategory = (from cate in context.Scategories
                                   where cate.SubCategoryOf == c.CategoryId
                                   select cate).ToList()
                });
                ViewBag.categories = categories;
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Account? acc = context.Accounts.FirstOrDefault(a => a.Email.ToLower() == email.ToLower());
            if (acc == null)
            {
                ViewBag.message = "Email không tồn tại";
                return View();
            }
            else
            {
                if(acc.Status == 0)
                {
                    ViewBag.message = "Tài khoản chưa được phê duyệt";
                    return View();
                }
                if(acc.Status == 2)
                {
                    ViewBag.message = "Tài khoản đã bị từ chối phê duyệt";
                }
                if (acc.Password != password)
                {
                    ViewBag.message = "Mật khẩu không đúng";
                    return View();
                }
                else
                {
                    Global.CurrentUser = acc;
                    if (acc.Role == 3) return RedirectToAction("Index", "Admin");
                    return RedirectToAction("Home");
                }
            }
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Account acc)
        {
            if (dao.GetAccountByEmail(acc.Email) != null)
            {
                ViewBag.emailExist = "Email has been taken";
                return View();
            }
            //Role 1 is student, 2 is teacher, 3 is admin/creator
            acc.Role = 1;
            acc.Status = 0;
            context.Accounts.Add(acc);
            int isSave = context.SaveChanges();
            ViewBag.message = isSave == 0 ? "Đăng ký tài khoản thất bại" : "Đăng ký tài khoản mới thành công";
            return View();
        }

        public IActionResult Logout()
        {
            Global.CurrentUser = null;
            return RedirectToAction("Home");
        }

    }
}