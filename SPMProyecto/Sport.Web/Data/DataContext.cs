using Microsoft.EntityFrameworkCore;
using Sport.Web.Data.Entities;

namespace Sport.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<Match> Matchs { get; set; }

        public DbSet<Team> Teams { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
       
    }
}
