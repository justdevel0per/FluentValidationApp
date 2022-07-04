using Microsoft.EntityFrameworkCore;

namespace OrnekUygulma.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
