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
    public class IndexModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public IndexModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<LibraryCard> LibraryCard { get;set; }

        public async Task OnGetAsync()
        {
            LibraryCard = await _context.LibraryCards
                .Include(l => l.Person)
                .OrderBy(a => a.Person.LastName)
                .ToListAsync();
        }
    }
}
