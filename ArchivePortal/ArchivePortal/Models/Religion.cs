using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Religion
    {
        public int Id { get; set; }
        public string ReligionName { get; set; }
        public string ReligionDescription { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
