using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInWPF
{
    public class EFInWPFInitializer : DropCreateDatabaseAlways<EFInWPFContext>
    {
        protected override void Seed(EFInWPFContext context)
        {
            context.Cursisten.Add(new Cursist
            {
                CursistNr = 1,
                Voornaam = "Marcel",
                Familienaam = "Kiekeboe"
            });

            context.Cursisten.Add(new Cursist
            {
                CursistNr = 2,
                Voornaam = "Charlotte",
                Familienaam = "Kiekeboe",
                MentorNr = 1               
            });

            context.Cursisten.Add(new Cursist
            {
                CursistNr = 3,
                Voornaam = "Fanny",
                Familienaam = "Kiekeboe",
                MentorNr = 2
            });

            context.Cursisten.Add(new Cursist
            {
                CursistNr = 4,
                Voornaam = "Konstantinopel",
                Familienaam = "Kiekeboe",
                MentorNr = 2
            });

            context.Cursisten.Add(new Cursist
            {
                CursistNr = 5,
                Voornaam = "Leon",
                Familienaam = "Van der Neffe"
            });

            context.Cursisten.Add(new Cursist
            {
                CursistNr = 6,
                Voornaam = "Firmin",
                Familienaam = "Van de Kasseien"
            });

            context.SaveChanges();
        }
    }
}
