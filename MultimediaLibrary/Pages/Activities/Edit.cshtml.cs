using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Data;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.Activities
{
    public class EditModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public EditModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["PersonID"] = new SelectList(_context.Persons, "PersonID", "FirstName");
           ViewData["SupplyID"] = new SelectList(_context.Supplies, "SupplyID", "Author");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityExists(Activity.ActivityID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ActivityExists(int id)
        {
            return _context.Activities.Any(e => e.ActivityID == id);
        }
    }
}
