using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Data;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.LibraryCards
{
    public class DeleteModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public DeleteModel(MultimediaLibrary.Data.LibraryContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LibraryCard = await _context.LibraryCards.FindAsync(id);

            if (LibraryCard != null)
            {
                _context.LibraryCards.Remove(LibraryCard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
