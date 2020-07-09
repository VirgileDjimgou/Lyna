using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutorial_ErsteSchritteRazorPages.Data;
using Tutorial_ErsteSchritteRazorPages.Modelle;

namespace Tutorial_ErsteSchritteRazorPages.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Tutorial_ErsteSchritteRazorPages.Data.Tutorial_ErsteSchritteRazorPagesContext _context;

        public DetailsModel(Tutorial_ErsteSchritteRazorPages.Data.Tutorial_ErsteSchritteRazorPagesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
