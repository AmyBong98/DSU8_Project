using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class EducationBackground
    {
        public int Id { get; set; }
        public int EducationTypeId { get; set; }
        public string EducationName { get; set; }
        public int EducationQualificationId { get; set; }
        public DateTime DateCommenced { get; set; }
        public DateTime DateLeft { get; set; }
        public int? AttachmentId { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
