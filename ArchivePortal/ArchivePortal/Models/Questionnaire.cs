using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Questionnaire
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public int GroupId { get; set; }
        public int RevisionNo { get; set; }
        public int? ModuleId { get; set; }
        public int? Type { get; set; }
        public int? CategoryGroupId { get; set; }
        public int? AttachmentId { get; set; }
        public bool? AllowScheduling { get; set; }
    }
}
