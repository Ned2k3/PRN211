using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.SignalR;
using System.Security.Principal;

namespace FinalProject.Models.ServiceModel
{
    public static class Global
    {
        public static Account? CurrentUser { get; set; }

        public static string[] GetBackgroundSource()
        {
            string[] bgSource =
            {
                "https://img.freepik.com/premium-vector/modern-simple-red-blue-abstract-background_181182-17398.jpg",
                "https://img.freepik.com/premium-vector/vector-abstract-background-with-overlap-layer-dynamic-shadow-background-eps-10_87783-553.jpg?w=360",
                "https://c4.wallpaperflare.com/wallpaper/604/404/38/abstract-geometry-minimalism-primary-colors-wallpaper-preview.jpg",
                "https://static.vecteezy.com/system/resources/previews/022/454/986/non_2x/simple-abstract-background-shiny-gradient-blue-background-illustration-of-abstract-background-for-wallpaper-layout-banner-display-or-design-graphic-free-vector.jpg",
                "https://picstatio.com/large/z_63hq/simple-material-design-wallpaper.jpg"
            };
            return bgSource;
        }

        public static string GetRandomBackground()
        {
            string[] source = GetBackgroundSource();
            Random random = new Random();
            int rand = random.Next(1,6) - 1;
            return source[rand];
        }

        public static dynamic GetEnrolledCourse()
        {
            using(var context = new PRN211_FinalProjectContext())
            {
                var courses = context.Enrolls.Where(e => e.AccountId == CurrentUser.AccountId).Select(e => new
                {
                    Course = e.Course
                }).ToList();
                return courses;
            }
        }

        public static List<(DateTime,DateTime)> GetCoursePeriod()
        {
            List<(DateTime, DateTime)> list = new List<(DateTime, DateTime)>();
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(6); 

            for (int i = 1; i <= 10; i++)
            {
                list.Add((start, end));
                start = start.AddDays(7); 
                end = start.AddDays(6);   
            }
            return list;
        }
    }
}
