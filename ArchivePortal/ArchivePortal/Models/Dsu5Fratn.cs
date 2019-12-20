using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Dsu5Fratn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public byte[] ArrivalPicture { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public byte[] DeparturePicture { get; set; }
    }
}
