using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.ViewModels
{
    public class AttractionReport
    {
        public string Name { get; set; }
        public int TotalVisits { get; set; }
        public double AverageVisits { get; set; }
        public int HighestVisits { get; set; }
        public DateTime HigestVisitsDate { get; set; }
        public int LowestVisits { get; set; }
        public DateTime LowestVisitsDate { get; set; }
        public int NumMaintenanceRequests { get; set; }
        public int DaysBroken { get; set; }
        public decimal MaintenanceCosts { get; set; }
    }
}
