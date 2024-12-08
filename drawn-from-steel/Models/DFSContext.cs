using Microsoft.EntityFrameworkCore;

namespace DrawnFromSteel.Models
{
    public class DFSContext : DbContext
    {
        public DbSet<Hero> Hero { get; set; } = null!;
        public DFSContext(DbContextOptions<DFSContext> options) : base(options) { }
    }
}
