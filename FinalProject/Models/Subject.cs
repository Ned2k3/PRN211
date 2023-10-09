using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Courses = new HashSet<Course>();
        }

        public int SubjectId { get; set; }
        public string SubjectCode { get; set; } = null!;
        public string SubjectName { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }
    }
}
