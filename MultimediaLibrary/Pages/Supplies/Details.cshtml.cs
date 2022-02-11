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
    public class DetailsModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public DetailsModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

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
    }
}
