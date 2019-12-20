using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class JobInterest
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public DateTime? DateAvailable { get; set; }
        public double CurrentSalary { get; set; }
        public double ExpectedSalary { get; set; }
        public string InterestDescription { get; set; }
        public string TargetInCareer { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
