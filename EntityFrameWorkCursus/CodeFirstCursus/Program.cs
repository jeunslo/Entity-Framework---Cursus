﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFCFContext>());
            using (var context = new EFCFContext())
            {
                //var jean = new Instructeur
                //{
                //    Voornaam = "Jean",
                //    Familienaam = "Smits",
                //    Wedde = 1000,
                //    InDienst = new DateTime(1994, 8, 1),
                //    HeeftRijbewijs = true,
                //    Adres = new Adres
                //    {
                //        Straat = "Keizerslaan",
                //        HuisNr = "11",
                //        PostCode = "1000",
                //        Gemeente = "Brussel"
                //    }
                //};
                //context.Instructeurs.Add(jean);
                //context.SaveChanges();

                //Console.WriteLine(jean.InstructeurNr);

                ////zoeken op primary key
                //Console.WriteLine(context.Instructeurs.Find(1).Familienaam);
                //Console.ReadLine();

                //*********************Inheritance TPH*********************
                //context.TPHCursussen.Add(new TPHKlassikaleCursus
                //{
                //    Naam = "Frans in 24 uur",
                //    Van = DateTime.Today,
                //    Tot = DateTime.Today
                //});

                //context.TPHCursussen.Add(new TPHZelfstudieCursus
                //{
                //    Naam = "Engels in 24 uur",
                //    AantalDagen = 1
                //});

                //*********************Inheritance TPC******************************
                //context.TPCCursussen.Add(new TPCKlassikaleCursus
                //{
                //    Naam = "Frans in 24 uur",
                //    Van = DateTime.Today,
                //    Tot = DateTime.Today
                //});

                //context.TPCCursussen.Add(new TPCZelfstudieCursus
                //{
                //    Naam = "Engels in 24 uur",
                //    AantalDagen = 1
                //});

                //*********************één-op-veel associaties*********************
                var campus = new ASSCampus
                {
                    Naam = "Delos",
                    Adres = new Adres
                    {
                        Straat = "Vlamingstraat",
                        HuisNr = "10",
                        PostCode = "8560", 
                        Gemeente = "Wevelgem"
                    }
                };

                var instructeur = new ASSInstructeur
                {
                    Voornaam = "Marcel",
                    Familienaam = "Kiekeboe",
                    Wedde = 100,
                    InDienst = new DateTime(1955, 1, 1),
                    HeeftRijbewijs = true,
                    Adres = new Adres
                    {
                        Straat = "Merholaan",
                        HuisNr = "1B",
                        PostCode = "2981",
                        Gemeente = "Zoersel-Parwijs"
                    },
                    Campus = campus
                };
                context.ASSCampussen.Add(campus);
                context.ASSInstructeurs.Add(instructeur);

                //*********************veel-op-veel associaties*********************
                var verantwoordelijkheid = new ASSVerantwoordelijkheid { Naam = "EHBO" };
                instructeur.ASSVerantwoordelijkheden = new List<ASSVerantwoordelijkheid> { verantwoordelijkheid }
                ;
                context.ASSVerantwoordelijkheden.Add(verantwoordelijkheid);

                //********************associatie naar dezelfde tabel*********************
                ASSCursist joe = new ASSCursist { Voornaam = "Joe", Familienaam = "Dalton" };
                ASSCursist averell = new ASSCursist { Voornaam = "Averell", Familienaam = "Dalton", Mentor = joe };

                context.Cursisten.Add(joe);
                context.Cursisten.Add(averell);


                context.SaveChanges();
                Console.WriteLine("Einde");
                Console.ReadLine();
                
            }
        }
    }
}
