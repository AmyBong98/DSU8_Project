using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Dsu7Indextable
    {
        public string Comp { get; set; }
        public string DocumentTyp { get; set; }
        public decimal DocumentNumber { get; set; }
        public string OrderTyp { get; set; }
        public decimal? OrderNumber { get; set; }
        public decimal? CustomerReference { get; set; }
        public decimal? SalesmanNumber { get; set; }
        public string SalesmanName { get; set; }
        public decimal? SoldTo { get; set; }
        public decimal? DeliveredTo { get; set; }
        public string SearchTyp { get; set; }
        public string BranchPlant { get; set; }
        public string Inv { get; set; }
        public string Pod { get; set; }
        public string PsnFrm { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Action { get; set; }
        public string ActionBy { get; set; }
    }
}
