using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.Pages.AttractionTypes
{
    public class IndexModel : PageModel
    {
        private readonly ThemeParkDatabase.Models.ThemeParkDatabaseContext _context;

        public IndexModel(ThemeParkDatabase.Models.ThemeParkDatabaseContext context)
        {
            _context = context;
        }

        public IList<AttractionType> AttractionType { get;set; }

        public async Task OnGetAsync()
        {
            AttractionType = await _context.AttractionType.ToListAsync();
        }
    }
}
