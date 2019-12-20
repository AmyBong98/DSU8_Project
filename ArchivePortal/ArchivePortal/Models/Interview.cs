using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Interview
    {
        public int Id { get; set; }
        public string InterviewedBy { get; set; }
        public DateTime InterviewedOn { get; set; }
        public int PositionInterviewedId { get; set; }
        public int Score { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
