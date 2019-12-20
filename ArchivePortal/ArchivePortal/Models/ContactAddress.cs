using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class ContactAddress
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
