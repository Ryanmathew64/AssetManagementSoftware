using AssetSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Info> Item { get; set; }
    }
}
