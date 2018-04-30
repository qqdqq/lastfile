using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThemeParkDatabase.Data;
using ThemeParkDatabase.Models;

namespace ThemeParkDatabase.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly ThemeParkDatabase.Models.ThemeParkDatabaseContext _context;
        private readonly ThemeParkDatabase.Data.ApplicationDbContext _appContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public DeleteModel(ThemeParkDatabase.Models.ThemeParkDatabaseContext context,
            ThemeParkDatabase.Data.ApplicationDbContext appContext,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _appContext = appContext;
            _userManager = userManager;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee
                .Include(e => e.Department).SingleOrDefaultAsync(m => m.Id == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FindAsync(id);

            if (Employee != null)
            {


                string userName = "emp" + Employee.Id + "@park.com";


                var user = await _userManager.FindByEmailAsync(userName);
                if (user != null)
                {
                    await _userManager.DeleteAsync(user);
                }


                _context.Employee.Remove(Employee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
