using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Data;
using MultimediaLibrary.Enums;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.Activities
{
    public class CreateModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public CreateModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "FullName");
        ViewData["SupplyID"] = new SelectList(_context.Supplies, "SupplyID", "Summary");
            return Page();
        }

        [BindProperty]
        public Activity Activity { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "FullName");
                ViewData["SupplyID"] = new SelectList(_context.Supplies, "SupplyID", "Summary");
                return Page();
            }

            Supply supply;
            try
            {
                Activity.ActivityDate = DateTime.Now;

                supply = _context.Supplies.Single(e => e.SupplyID == Activity.SupplyID);
                supply.SupplyStatus = (SupplyStatus)(int)Activity.ActivityType;

                _context.Activities.Add(Activity);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return RedirectToPage("./Index");
        }
    }
}
