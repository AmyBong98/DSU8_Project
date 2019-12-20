using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Skill
    {
        public int Id { get; set; }
        public string TypingSpeed { get; set; }
        public string Shorthand { get; set; }
        public string It { get; set; }
        public string Management { get; set; }
        public string Others { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
