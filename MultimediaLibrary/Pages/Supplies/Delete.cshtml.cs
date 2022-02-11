using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Data;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.NewFolder
{
    public class DeleteModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public DeleteModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Supply Supply { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supply = await _context.Supplies.FirstOrDefaultAsync(m => m.SupplyID == id);

            if (Supply == null)
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

            Supply = await _context.Supplies.FindAsync(id);

            if (Supply != null)
            {
                _context.Supplies.Remove(Supply);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
