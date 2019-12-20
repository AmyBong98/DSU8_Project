using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public byte[] FileBinary { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsTemporary { get; set; }
    }
}
