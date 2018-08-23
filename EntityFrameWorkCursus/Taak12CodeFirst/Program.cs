using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Taak12CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CFArtikelContext>());
            using (var context = new CFArtikelContext())
            {
                Artikel hamburger = new FoodArtikel
                {
                    Naam = "Hamburger",
                    Houdbaarheid = 1
                };

                Artikel stoel = new NonFoodArtikel
                {
                    Naam = "Stoel",
                    Garantie = 1
                };
               

                Artikelgroep meubel = new Artikelgroep
                {
                    Naam = "Meubel"
                };
                

                Leverancier fedEx = new Leverancier
                {
                    Naam = "fedEx"
                };

                fedEx.Artikels = new List<Artikel> { hamburger, stoel };
                hamburger.ASSLeveranciers = new List<Leverancier> { fedEx };
                stoel.ASSLeveranciers = new List<Leverancier> { fedEx };
                meubel.Artikels = new List<Artikel> { stoel };
                context.Artikels.Add(hamburger);
                context.Artikels.Add(stoel);
                context.Artikelgroepen.Add(meubel);
                context.Leveranciers.Add(fedEx);




                context.SaveChanges();
                Console.WriteLine("Einde");
                Console.ReadLine();
            }
        }
    }
}
