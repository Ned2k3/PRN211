using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class Account
    {
        public Account()
        {
            Courses = new HashSet<Course>();
            Enrolls = new HashSet<Enroll>();
        }

        public int AccountId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Fullname { get; set; }
        public int Role { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Enroll> Enrolls { get; set; }
    }
}
