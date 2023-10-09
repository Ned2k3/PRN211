using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class Enroll
    {
        public int EnrollId { get; set; }
        public int? AccountId { get; set; }
        public int? CourseId { get; set; }
        public DateTime EntrollDate { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Course? Course { get; set; }
    }
}
