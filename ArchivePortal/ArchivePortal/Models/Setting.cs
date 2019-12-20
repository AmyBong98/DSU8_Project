using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        public string Client { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
