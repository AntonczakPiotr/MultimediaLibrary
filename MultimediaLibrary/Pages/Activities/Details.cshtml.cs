﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Data;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.Activities
{
    public class DetailsModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public DetailsModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        public Activity Activity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Activity = await _context.Activities
                .Include(a => a.Person)
                .Include(a => a.Supply).FirstOrDefaultAsync(m => m.ActivityID == id);

            if (Activity == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
