using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using bivaa_server_main.Models;

namespace bivaa_server_main
{
    
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<patient> patient { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<patient>()
               .Property(e => e.name)
               .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.diagnose)
                .IsUnicode(false);
        }
    
    }
}
