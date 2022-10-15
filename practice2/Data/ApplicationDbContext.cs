using Microsoft.EntityFrameworkCore;
using practice2.Models;

namespace practice2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> books { get; set; }

        public DbSet<Customer> customers { get; set; }

    }
}
