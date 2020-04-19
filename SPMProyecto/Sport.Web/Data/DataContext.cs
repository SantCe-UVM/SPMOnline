﻿using Microsoft.EntityFrameworkCore;
using Sport.Web.Data.Entities;

namespace Sport.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        //public DbSet<Tournament> Tournaments { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
