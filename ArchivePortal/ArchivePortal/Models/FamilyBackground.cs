using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class FamilyBackground
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Relationship { get; set; }
        public string Occupation { get; set; }
        public string Organization { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
