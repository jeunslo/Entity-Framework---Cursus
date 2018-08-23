using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak12CodeFirst
{
    public class CFArtikelContext : DbContext
    {
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<Artikelgroep> Artikelgroepen { get; set; }
        public DbSet<Leverancier> Leveranciers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikel>()
                        .HasMany(i => i.ASSLeveranciers)
                        .WithMany(v => v.Artikels)
                        .Map(c => c.ToTable("ArtikelLeveranciers")
                        .MapLeftKey("LeverancierId")
                        .MapRightKey("ArtikelId"));                 
        }
    }
}
