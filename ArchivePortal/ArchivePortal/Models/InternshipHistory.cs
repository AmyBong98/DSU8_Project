using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class InternshipHistory
    {
        public int Id { get; set; }
        public string UniversityName { get; set; }
        public string CourseName { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? CurrentSemester { get; set; }
        public int? TotalSemester { get; set; }
        public DateTime? StartDateInternship { get; set; }
        public DateTime? EndDateInternship { get; set; }
        public DateTime? GraduationDate { get; set; }
        public decimal? LatestCgpa { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public int? ContactId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
