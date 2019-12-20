using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class ContactIdentificationType
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int IdentificationTypeId { get; set; }
        public string IdentificationNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
