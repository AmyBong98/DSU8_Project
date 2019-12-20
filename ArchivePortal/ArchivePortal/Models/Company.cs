using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusinessTypeId { get; set; }
        public string WebsiteUrl { get; set; }
        public string BusinessNature { get; set; }
        public string TaxCountry { get; set; }
        public string Ssm { get; set; }
        public string Sst { get; set; }
        public int BumiStatus { get; set; }
        public string BumiEquity { get; set; }
        public double? AuthorizedCapital { get; set; }
        public double? PaidUpCapital { get; set; }
        public bool? BankGuarantee { get; set; }
        public bool? Overdraft { get; set; }
        public bool? LetterOfCredit { get; set; }
        public string OtherFacility { get; set; }
        public DateTime? DateIncoporate { get; set; }
        public string Awards { get; set; }
        public int? TaxCodeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public int Status { get; set; }
        public bool IsCompleted { get; set; }
        public int? AttachmentId { get; set; }
    }
}
