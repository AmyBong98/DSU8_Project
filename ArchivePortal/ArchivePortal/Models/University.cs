using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class University
    {
        public int Id { get; set; }
        public string UniversityName { get; set; }
        public DateTime? EstablishedDate { get; set; }
        public string UniversityDescription { get; set; }
        public bool? IsPublic { get; set; }
        public bool? Islocal { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
