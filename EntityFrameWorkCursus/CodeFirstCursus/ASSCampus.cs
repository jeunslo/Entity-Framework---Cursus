using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    [Table("ASSCampussen")]
    public class ASSCampus
    {
        public int ASSCampusId { get; set; }
        [Required]
        [StringLength(50)]
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public virtual ICollection<ASSInstructeur> ASSInstructeurs { get; set; }
    }
}
