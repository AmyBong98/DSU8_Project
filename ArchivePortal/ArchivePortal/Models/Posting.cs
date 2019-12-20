using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Posting
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Location1 { get; set; }
        public int? Duration1 { get; set; }
        public string Location2 { get; set; }
        public int? Duration2 { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
