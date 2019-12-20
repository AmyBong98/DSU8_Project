using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class ContactLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int ContactId { get; set; }
        public int? SpokenProficiency { get; set; }
        public int? WrittenProficiency { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
