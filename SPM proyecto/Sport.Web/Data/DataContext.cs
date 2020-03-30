using Microsoft.EntityFrameworkCore;
using Sport.Web.Data.Entities;

namespace Sport.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Sport.Web.Data.Entities;

    public class DataContext : DbContext
        {
          public DbSet<Player> Players { get; set; }
         //public DbSet<Tournament> Tournaments { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options) 
            {
            }
        public DbSet<Tournament> Tournaments { get; set; }


        public DbSet<Sport.Web.Data.Entities.Tournament> Tournament { get; set; }
        }
    
}
