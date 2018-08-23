using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    [Table("TPCZelfstudieCursus")]
    public class TPCZelfstudieCursus : TPCCursus
    {
        public int AantalDagen { get; set; }
    }
}
