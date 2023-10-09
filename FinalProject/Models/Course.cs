using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrolls = new HashSet<Enroll>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int? Creator { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Scategory? Category { get; set; }
        public virtual Account? CreatorNavigation { get; set; }
        public virtual ICollection<Enroll> Enrolls { get; set; }
    }
}
