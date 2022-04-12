using AuthBasicwithDB.Models;

using Microsoft.EntityFrameworkCore;

namespace AuthBasicwithDB.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
      public  DbSet<User> Users { get; set; }
      public  DbSet<Beer> Beers { get; set; }
      public DbSet<Stock> Stock { get; set; }

    }
}
