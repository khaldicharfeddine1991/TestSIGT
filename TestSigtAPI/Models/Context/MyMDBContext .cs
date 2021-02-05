using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSigtAPI.Models.Context
{
    public class MyDBContext: DbContext
      {
        public MyDBContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          
            builder.Entity<User>().HasKey(e => new { e.Id });
            builder.Entity<Experience>().HasKey(e => new { e.Id });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    public DbSet<Experience> Experiences { get; set; }

  
}
}
