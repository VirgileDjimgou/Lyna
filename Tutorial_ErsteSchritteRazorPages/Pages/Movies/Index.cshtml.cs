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
    public class IndexModel : PageModel
    {
        private readonly Tutorial_ErsteSchritteRazorPages.Data.Tutorial_ErsteSchritteRazorPagesContext _context;

        public IndexModel(Tutorial_ErsteSchritteRazorPages.Data.Tutorial_ErsteSchritteRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
