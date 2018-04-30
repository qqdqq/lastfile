using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.ViewModels
{
    public class VendorReport
    {
        public string Name { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalSalesGoals { get; set; }
        public decimal Profit { get; set; }
        public double ProfitMargin { get; set; }
    }
}

