using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThemeParkDatabase.Models;
using ThemeParkDatabase.Data;
using Microsoft.AspNetCore.Authorization;

namespace ThemeParkDatabase.Pages.Employees
{
    [Authorize(Roles = "Admin, Manager")]
    public class CreateModel : PageModel
    {
        private readonly ThemeParkDatabase.Models.ThemeParkDatabaseContext _context;
        private readonly ThemeParkDatabase.Data.ApplicationDbContext _appContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IServiceProvider _service;

        public CreateModel(ThemeParkDatabase.Models.ThemeParkDatabaseContext context,
            ThemeParkDatabase.Data.ApplicationDbContext appContext,
            UserManager<ApplicationUser> userManager,
            IServiceProvider service)
        {
            _context = context;
            _appContext = appContext;
            _userManager = userManager;
            _service = service;
        }

        public IActionResult OnGet()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //string passWord = Employee.LastName + Employee.FirstName + "" + Employee.Id + "@Password123";
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();


            string userName = "emp" + Employee.Id + "@park.com";
            string passWord = "abcdeF123@4";
            var user = new ApplicationUser { UserName = userName, Email = userName };
            await _userManager.CreateAsync(user, passWord);
            await _userManager.AddToRoleAsync(user, "Employee");


            return RedirectToPage("./Index");
        }
    }
}