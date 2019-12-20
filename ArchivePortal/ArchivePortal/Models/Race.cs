using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Race
    {
        public int Id { get; set; }
        public string RaceName { get; set; }
        public string RaceDescription { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
