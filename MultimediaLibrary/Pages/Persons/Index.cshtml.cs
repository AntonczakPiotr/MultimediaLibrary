using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Data;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly MultimediaLibrary.Data.LibraryContext _context;

        public IndexModel(MultimediaLibrary.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Persons
                .OrderBy(a => a.LastName)
                .ThenBy(a => a.FirstName)
                .ToListAsync();
        }
    }
}
