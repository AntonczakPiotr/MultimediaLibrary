using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultimediaLibrary.Data;
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
        ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "FirstName");
        ViewData["SupplyID"] = new SelectList(_context.Supplies, "SupplyID", "Author");
            return Page();
        }

        [BindProperty]
        public Activity Activity { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Activities.Add(Activity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
