using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Project
    {
        public int Id { get; set; }
        public string ProjectRefNo { get; set; }
        public string ProjectName { get; set; }
        public decimal ProjectValue { get; set; }
        public string ProjectStatus { get; set; }
        public string PojectClient { get; set; }
        public string ProjectClientContact { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerContact { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public int CompanyId { get; set; }
    }
}
