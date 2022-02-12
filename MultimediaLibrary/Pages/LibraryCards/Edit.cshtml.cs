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

namespace MultimediaLibrary.Pages.LibraryCards
{
    public class EditModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public EditModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LibraryCard LibraryCard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LibraryCard = await _context.LibraryCards
                .Include(l => l.Person).FirstOrDefaultAsync(m => m.LibraryCardID == id);

            if (LibraryCard == null)
            {
                return NotFound();
            }
           ViewData["PersonID"] = new SelectList(_context.Persons, "Właściciel", "FullName");
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

            _context.Attach(LibraryCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraryCardExists(LibraryCard.LibraryCardID))
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

        private bool LibraryCardExists(int id)
        {
            return _context.LibraryCards.Any(e => e.LibraryCardID == id);
        }
    }
}
