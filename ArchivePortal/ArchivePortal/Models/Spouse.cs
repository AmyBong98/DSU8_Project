using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Spouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? DateMarriage { get; set; }
        public string Occupation { get; set; }
        public string EmployerName { get; set; }
        public string Address { get; set; }
        public string MainPhoneNumber { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
