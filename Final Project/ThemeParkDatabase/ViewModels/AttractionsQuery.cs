using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.ViewModels
{
    public class AttractionsQuery
    {
        public AttractionsQuery(ThemeParkDatabaseContext context, ReportQuery query)
        {
            ReportQuery = query;
            Attractions = context.Attraction
                .Include(a => a.AttractionVisit)
                .Include(a => a.AttractionType)
                .Include(a => a.MaintenanceRequest)
                .Include(a => a.Location)
                .ToList();
        }

        public ReportQuery ReportQuery { get; set; }
        public List<Attraction> Attractions { get; set; }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.ViewModels
{
    public class AttractionsQuery
    {
        public ReportQuery ReportQuery { get; set; }
        public List<Attraction> Attractions { get; set; }
    }
}*/


