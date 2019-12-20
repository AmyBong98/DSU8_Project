using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
