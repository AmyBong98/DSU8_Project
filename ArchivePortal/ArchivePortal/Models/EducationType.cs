using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class EducationType
    {
        public int Id { get; set; }
        public string EducationName { get; set; }
        public string EducationDescription { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
