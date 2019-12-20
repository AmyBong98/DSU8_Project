using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class ProductQuestionnaire
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuestionnaireGroupId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
