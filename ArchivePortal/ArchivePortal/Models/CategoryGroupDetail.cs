﻿using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class CategoryGroupDetail
    {
        public int Id { get; set; }
        public int CategoryGroupHeaderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
