﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThemeParkDatabase.Pages
{
    //comment work plz
    [Authorize(Roles = "Admin, Manager, Employee")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
