using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstCursus
{
    public class EFCFContext : DbContext
    {
        public DbSet<Instructeur> Instructeurs { get; set; }
        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Land> Landen { get; set; }

        public DbSet<TPHCursus> TPHCursussen { get; set; }
        public DbSet<TPCCursus> TPCCursussen { get; set; }

        public DbSet<ASSCampus> ASSCampussen { get; set; }
        public DbSet<ASSInstructeur> ASSInstructeurs { get; set; }
        public DbSet<ASSVerantwoordelijkheid> ASSVerantwoordelijkheden { get; set; }

        public DbSet<ASSCursist> Cursisten { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TPHKlassikaleCursus>().Map(m => m.Requires("Soort").HasValue("K"));
            modelBuilder.Entity<TPHZelfstudieCursus>().Map(m => m.Requires("Soort").HasValue("Z"));

            modelBuilder.Entity<TPCKlassikaleCursus>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<TPCZelfstudieCursus>().Map(m => m.MapInheritedProperties());

            modelBuilder.Entity<ASSInstructeur>()
                        .HasMany(i => i.ASSVerantwoordelijkheden)
                        .WithMany(v => v.ASSInstructeurs)
                        .Map(c => c.ToTable("InstructeursVerantwoordelijkheden")
                        .MapLeftKey("VerantwoordelijkheidID")
                        .MapRightKey("InstructeurNr"));
            
        }
    }
}
