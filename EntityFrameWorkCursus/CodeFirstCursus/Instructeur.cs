﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    public class Instructeur
    {
        [Key]
        public int InstructeurNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        [Column("maandwedde")]
        public decimal Wedde { get; set; }
        [Column(TypeName ="date")]
        public DateTime InDienst { get; set; }
        public bool? HeeftRijbewijs { get; set; }
        public Adres Adres { get; set; }

        public void Opslag(decimal percentage)
        {
            Wedde *= (1m + percentage / 1000m);
        }
    }
}
