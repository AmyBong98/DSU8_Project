﻿using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Nationality
    {
        public int Id { get; set; }
        public string NationalityName { get; set; }
        public string NationalityShortName2 { get; set; }
        public string NationalityShortName3 { get; set; }
        public string NationalityDescription { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
