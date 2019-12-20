using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class LicenseClass
    {
        public int Id { get; set; }
        public string LicenseClassName { get; set; }
        public string LicenseClassDescription { get; set; }
        public bool IsLocallicense { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
