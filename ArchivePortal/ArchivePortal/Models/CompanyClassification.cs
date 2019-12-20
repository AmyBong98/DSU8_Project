using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class CompanyClassification
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ClassificationId { get; set; }
        public int? SubClassificationId { get; set; }
        public int? GradesId { get; set; }
        public string CertifyingAgency { get; set; }
        public string Certificate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AttachmentId { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
