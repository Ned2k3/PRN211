using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class Scategory
    {
        public Scategory()
        {
            Courses = new HashSet<Course>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int SubCategoryOf { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
