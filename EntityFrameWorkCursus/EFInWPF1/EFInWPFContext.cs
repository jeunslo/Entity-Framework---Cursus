using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFInWPF
{
    public class EFInWPFContext : DbContext
    {
        public DbSet<Cursist> Cursisten { get; set; }
    }
}
