using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Book_Store.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

       public DbSet<Book> Books { get; set; }
    }
}
