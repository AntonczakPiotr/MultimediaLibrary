using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultimediaLibrary.Data;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Pages.LibraryCards
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
            return Page();
        }

        [BindProperty]
        public LibraryCard LibraryCard { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LibraryCards.Add(LibraryCard);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
