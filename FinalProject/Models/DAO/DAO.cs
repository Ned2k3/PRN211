using FinalProject.Models.ServiceModel;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;

namespace FinalProject.Models.DAO
{
    public class DAO
    {
        private readonly PRN211_FinalProjectContext context;
        public DAO()
        {
            context = new PRN211_FinalProjectContext();
        }

        public dynamic GetAllCourseCategory()
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
            return categories;
        }

        public dynamic GetSubCategoryList(int id)
        {
            var sublist = context.Scategories.Where(c => c.SubCategoryOf == id).Select(c => new
            {
                Name = c.CategoryName,
                ID = c.CategoryId,
                SubID = c.SubCategoryOf,
                Subcategory = (from cate in context.Scategories
                               where cate.SubCategoryOf == c.CategoryId
                               select cate).ToList()
            }).ToList();
            return sublist;
        }
        public Scategory? GetCategoryById(int id)
        {
            return context.Scategories.SingleOrDefault(s => s.CategoryId == id);
        }
        public dynamic GetCourseListByCategory(int cateID)
        {
            var list = context.Courses.Where(c => c.CategoryId == cateID).Select(c => new
            {
                ID = c.CourseId,
                Name = c.CourseName,
                Creator = c.CreatorNavigation,
                Category = c.Category,
                isEnroll = (from enroll in context.Enrolls
                            where enroll.CourseId == c.CourseId && enroll.AccountId == Global.CurrentUser.AccountId
                            select enroll).ToList().Count
            }).ToList();
            return list;
        }

        public List<Enroll> GetStudentCourse(int id)
        {
            List<Enroll> enrolls = context.Enrolls.Where(e => e.AccountId == id).ToList();
            return enrolls;
        }

        public Account? GetAccountByEmail(string email)
        {
            Account? acc = context.Accounts.Where(a => a.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
            return acc;
        }

        public Account? GetAccountById(int id)
        {
            Account? acc = context.Accounts.Where(a => a.AccountId == id).FirstOrDefault();
            return acc;
        }

        public void ConfirmApprove(Account account)
        {
            account.Status = 1;
            context.SaveChanges();
        }

        public void ConfirmReject(Account account)
        {
            account.Status = 2;
            context.SaveChanges();
        }
        public Enroll? isEnrolled(int cid, int userId)
        {
            return context.Enrolls.FirstOrDefault(c => c.CourseId == cid && c.AccountId  == userId);
        }
        public dynamic GetCourseListBySearchKey(string key)
        {
            var list = context.Courses.Where(c => c.CourseName.Contains(key) || c.CreatorNavigation.Fullname.Contains(key) || c.Category.CategoryName.Contains(key)).Select(c => new
            {
                ID = c.CourseId,
                Name = c.CourseName,
                Creator = c.CreatorNavigation,
                Category = c.Category,
                isEnroll = (from enroll in context.Enrolls
                            where enroll.CourseId == c.CourseId && enroll.AccountId == Global.CurrentUser.AccountId
                            select enroll).ToList().Count
            }).ToList();
            return list;
        }

        public Course? GetCourseByID(int id)
        {
            Course? course = context.Courses.FirstOrDefault(c => c.CourseId == id);
            return course;
        }
        public Account? GetCourseCreator(int? creatorID)
        {
            Account? acc = context.Accounts.FirstOrDefault(a => a.AccountId == creatorID);
            return acc;
        }
        public Scategory? GetCourseCategory(int? cateID)
        {
            Scategory? cate = context.Scategories.FirstOrDefault(s => s.CategoryId == cateID);
            return cate;
        }
        public void EnrollCourse(Enroll enroll)
        {
            if (enroll == null) return;
            context.Enrolls.Add(enroll);
            context.SaveChanges();
        }

        public List<Account> GetWaitingApproveAccount()
        {
            List<Account> list = context.Accounts.Where(a => a.Status == 0).ToList();
            return list;
        }

        public dynamic GetMyCourse()
        {
            var list = context.Courses.Where(c => c.Creator == Global.CurrentUser.AccountId).Select(c => new
            {
                ID = c.CourseId,
                Name = c.CourseName,
                Creator = c.CreatorNavigation,
                Category = c.Category,
                startdate = c.StartDate,
                enddate = c.EndDate
            }).ToList();
            return list;
        }
    }
}
