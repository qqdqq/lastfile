using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.ViewModels
{
    public class VendorsQuery
    {
        public VendorsQuery(ThemeParkDatabaseContext context, ReportQuery query)
        {
            ReportQuery = query;
            Vendors = context.Vendor
                .Include(v => v.Location)
                .Include(v => v.VendorSalesReport)
                .Include(v => v.VendorType)
                .ToList();
        }

        public ReportQuery ReportQuery { get; set; }
        public List<Vendor> Vendors { get; set; }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.ViewModels
{
    public class VendorsQuery
    {
        public ReportQuery ReportQuery { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<VendorType> VendorTypes { get; set; }
    }
}*/
