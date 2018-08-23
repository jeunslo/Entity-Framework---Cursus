using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak12CodeFirst
{
    [Table("Artikels")]
    public abstract class Artikel
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public virtual ICollection<Leverancier> ASSLeveranciers { get; set; }
        public Artikelgroep ASSArtikelgroep { get; set; }
        public int? ASSArtikelgroepId { get; set; }
    }
}
