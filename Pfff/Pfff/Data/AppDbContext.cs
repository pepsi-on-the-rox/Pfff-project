using Pfff.Models;
using Microsoft.EntityFrameworkCore;

namespace Pfff.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Camera> Cameras { get; set; }
    }
}
