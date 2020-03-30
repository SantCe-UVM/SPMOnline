using Microsoft.EntityFrameworkCore;

namespace Sports.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }
    }
}
