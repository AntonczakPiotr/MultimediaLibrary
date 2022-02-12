using System;
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
    public class IndexModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public IndexModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<Activity> Activity { get;set; }

        public async Task OnGetAsync()
        {
            Activity = await _context.Activities
                .Include(a => a.Person)
                .Include(a => a.Supply).ToListAsync();
        }
    }
}
