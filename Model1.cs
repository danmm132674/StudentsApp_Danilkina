using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentsApp_Danilkina
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Gruppa)
                .IsUnicode(false);
        }
    }
}
