using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tutorial_ErsteSchritteRazorPages.Modelle;

namespace Tutorial_ErsteSchritteRazorPages.Data
{
    public class Tutorial_ErsteSchritteRazorPagesContext : DbContext
    {
        public Tutorial_ErsteSchritteRazorPagesContext (DbContextOptions<Tutorial_ErsteSchritteRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<Tutorial_ErsteSchritteRazorPages.Modelle.Movie> Movie { get; set; }
    }
}
