using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.ViewModels
{
    public class VisitorsQuery
    {
        public VisitorsQuery(ThemeParkDatabaseContext context, ReportQuery query)
        {
            ReportQuery = query;
            DailyParkReports = context.DailyParkReport.ToList();
        }

        public ReportQuery ReportQuery { get; set; }
        public List<DailyParkReport> DailyParkReports { get; set; }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.ViewModels
{
    public class VisitorsQuery
    {
        public ReportQuery ReportQuery { get; set; }
        public List<Visitor> Visitors { get; set; }
        public List<DailyParkReport> DailyParkReports { get; set; }
    }
}*/
