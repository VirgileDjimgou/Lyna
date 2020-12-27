using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_API_NET_Core_und_MongoDB.Modelle;

namespace Web_API_NET_Core_und_MongoDB.Data
{
    public class Web_API_NET_Core_und_MongoDBContext : DbContext
    {
        public Web_API_NET_Core_und_MongoDBContext (DbContextOptions<Web_API_NET_Core_und_MongoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Web_API_NET_Core_und_MongoDB.Modelle.Book> Book { get; set; }
    }
}
