using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Dsu7Filetable
    {
        public int DocumentSequence { get; set; }
        public string Comp { get; set; }
        public string DocumentTyp { get; set; }
        public decimal DocumentNumber { get; set; }
        public string Url { get; set; }
        public string FileType { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string SentBy { get; set; }
    }
}
