using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class EmploymentHistory
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int PositionId { get; set; }
        public string JobDescription { get; set; }
        public string ReasonLeaving { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateLeft { get; set; }
        public double? StartingPay { get; set; }
        public double? LastPay { get; set; }
        public double? Bonus { get; set; }
        public double? TravelAllowance { get; set; }
        public double? OtherAllowance { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
