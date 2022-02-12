using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace bivaa_server_main.Models
{
    public partial class ModelFojtu : DbContext
    {
        public ModelFojtu()
            : base("name=ModelFojtu")
        {
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
