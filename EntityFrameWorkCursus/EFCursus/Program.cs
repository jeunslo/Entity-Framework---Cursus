using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    foreach (var docent in entities.Docenten)
            //    {
            //        Console.WriteLine(docent.Naam); 
            //    } 
            //}
            //Console.ReadLine();


            //****************************************************************************************
            //Console.WriteLine("Minimum wedde:");

            //decimal minWedde;

            //if (decimal.TryParse(Console.ReadLine(), out minWedde))
            //{
            //    Console.WriteLine("Sorteren=:);=op wedde:1=opwedde, 2=op familienaam, 3=op voornaam:");
            //    var sorterenOp = Console.ReadLine();
            //    Func<Docent, Object> sorteerLambda;

            //    switch(sorterenOp)
            //    {
            //        case "1":
            //            sorteerLambda = (docent) => docent.Wedde;
            //            break;
            //        case "2":
            //            sorteerLambda = (docent) => docent.Familienaam;
            //            break;
            //        case "3":
            //            sorteerLambda = (docent) => docent.Voornaam;
            //            break;
            //        default:
            //            Console.WriteLine("Verkeerde keuze");
            //            sorteerLambda = null;
            //            break;
            //    }

            //    if (sorteerLambda != null)
            //    {
            //        using (var entities = new EFOpleidingenEntities())
            //        {
            //            var query = entities.Docenten.Where(x => x.Wedde >= minWedde).OrderBy(sorteerLambda);

            //            foreach (var docent in query)
            //            {
            //                Console.WriteLine("{0}: {1}", docent.Naam, docent.Wedde);
            //            }
            //        }
            //    }
            //}
            //else
            //    Console.WriteLine("Tik een getal");

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    Console.WriteLine("DocentNr.:");

            //    if(int.TryParse(Console.ReadLine(), out int docentNr))
            //    {
            //        var docent = entities.Docenten.Find(docentNr);
            //        Console.WriteLine(docent == null ? "Niey gevonden" : docent.Naam);
            //    }

            //    else
            //        Console.WriteLine("U tikte geen getal");
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    //var query = from docent in entities.Docenten
            //    //            group docent by docent.Naam.Voornaam into VoornaamGroep
            //    //            select new { VoornaamGroep, Voornaam = VoornaamGroep.Key };
            //    //var query = entities.Docenten.GroupBy(x => x.Naam.Voornaam,
            //    //(y, z) => new { y, z });

            //    //foreach (var voornaamStatistiek in query)
            //    //{
            //    //    Console.WriteLine(voornaamStatistiek.y);
            //    //    Console.WriteLine(new string('-', voornaamStatistiek.y.Length));

            //    //    foreach (var docent in voornaamStatistiek.z)
            //    //    {
            //    //        Console.WriteLine(docent.Naam);
            //    //    }

            //    //    Console.WriteLine();
            //    //}
            //    var query = from docent in entities.Docenten
            //                group docent by docent.Naam.Voornaam into x
            //                where x.Key.Length > 7
            //                select x;
                            
            //    foreach (var y in query)
            //    {
            //        Console.WriteLine(y.Key);
            //        Console.WriteLine("----------------------------");
            //        foreach (var z in y)
            //        {
            //            Console.WriteLine(z.Naam);
            //        }
            //    }

            //    Console.ReadLine();
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    Console.WriteLine("Deel naam campus:");
            //    var deelNaam = Console.ReadLine();

            //    var query = from campus in entities.Campussen.Include("Docenten")
            //                where campus.Naam.Contains(deelNaam)
            //                orderby campus.Naam
            //                select campus;

            //    foreach (var campus in query)
            //    {
            //        var campusNaam = campus.Naam;
            //        Console.WriteLine(campusNaam);
            //        Console.WriteLine(new string('-', campusNaam.Length));

            //        foreach (var docent in campus.Docenten)
            //        {
            //            Console.WriteLine(docent.Naam);
            //        }

            //        Console.WriteLine();
            //    }

            //    Console.ReadLine();

            //}

            //****************************************************************************************
            //var campus = new Campus { Naam = "Naam1", Straat = "Straat1", HuisNr = "1", PostCode = "1111", Gemeente = "Gemeente" };

            //using (var entities = new EFOpleidingenEntities())
            //{
            //    entities.Campussen.Add(campus);
            //    entities.SaveChanges();
            //    Console.WriteLine(campus.CampusNr);
            //}

            //Console.ReadKey();

            //****************************************************************************************
            //var docent3 = new Docent { Voornaam = "Voornaam3", Familienaam = "Familienaam3", Wedde = 3 };

            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var campus1 = entities.Campussen.Find(1);

            //    if(campus1 != null)
            //    {
            //        docent3.Campus = campus1;
            //        entities.Docenten.Add(docent3);
            //        entities.SaveChanges();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Campus 1 niet gevonden");
            //    }
            //}

            //****************************************************************************************
            //Console.Write("DocentNr.:");

            //if(int.TryParse(Console.ReadLine(), out int docentNr))
            //{
            //    using (var entities = new EFOpleidingenEntities())
            //    {
            //        var docent = entities.Docenten.Find(docentNr);
            //        if(docent != null)
            //        {
            //            Console.WriteLine("Wedde:" + docent.Wedde);
            //            Console.Write("Bedrag:");

            //            if (decimal.TryParse(Console.ReadLine(), out decimal bedrag))
            //            {
            //                docent.Opslag(bedrag);
            //                entities.SaveChanges();
            //            }
            //            else
            //                Console.WriteLine("Tik een getal");
            //        }
            //        else
            //            Console.WriteLine("Docent niet gevonden");
            //    }
            //}
            //else
            //    Console.WriteLine("Tik een getal");

            //****************************************************************************************
            //try
            //{
            //    Console.WriteLine("Artikel nr.:");
            //    var artikelNr = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Van magazijn nr.:");
            //    var vanMagazijnNr = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Naar magazijn nr:");
            //    var naarMagazijnNr = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Aantal stuks:");
            //    var aantalStuks = int.Parse(Console.ReadLine());

            //    //VoorraadTransfer1(artikelNr, vanMagazijnNr, naarMagazijnNr, aantalStuks);
            //    //VoorraadTransfer2(artikelNr, vanMagazijnNr, naarMagazijnNr, aantalStuks);
            //    //VoorraadBijvulling1(artikelNr, vanMagazijnNr, aantalStuks);
            //    VoorraadBijvulling2(artikelNr, vanMagazijnNr, aantalStuks);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Tik een getal");
            //}
            //Console.ReadLine();

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from boek in entities.Boeken.Include("Cursussen")
            //                orderby boek.Titel
            //                select boek;

            //    foreach (var boek in query)
            //    {
            //        Console.WriteLine(boek.Titel);
            //        foreach (var cursus in boek.Cursussen)
            //        {
            //            Console.WriteLine("\t{0}", cursus.Naam);
            //        }
            //    }
            //}
            //Console.ReadLine();

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from cursus in entities.Cursussen.Include("Boeken")
            //                orderby cursus.Naam
            //                select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);

            //        foreach (var boek in cursus.Boeken)
            //        {
            //            Console.WriteLine("\t{0}", boek.Titel);
            //        }
            //    }
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var nieuwBoek = new Boek { ISBNNr = "0-0788210-6-1", Titel = "Oracle Backup & Recovery Handbook" };

            //    var oracleCursus = (from cursus in entities.Cursussen
            //                        where cursus.Naam == "Oracle"
            //                        select cursus).FirstOrDefault();

            //    if (oracleCursus != null)
            //    {
            //        oracleCursus.Boeken.Add(nieuwBoek);
            //        entities.SaveChanges();
            //    }
            //    else
            //        Console.WriteLine("Cursus Oracle niet gevonden");
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from cursus2 in entities.Cursussen2.Include("BoekenCursussen2.Boek2")
            //                orderby cursus2.Naam
            //                select cursus2;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);

            //        foreach (var boekCursus in cursus.BoekenCursussen2)
            //        {
            //            Console.WriteLine("\t{0}:{1}", boekCursus.VolgNr, boekCursus.Boek2.Titel);
            //        }
            //    }
            //}
            //Console.ReadLine();

            //****************************************************************************************
            //var nieuwBoek = new Boek2() { ISBNNr = "0-201-70431-5", Titel = "Modern C++ Design" };

            //var transactionOptions = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.Serializable };

            //using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            //{
            //    using (var entities = new EFOpleidingenEntities())
            //    {
            //        var query = from cursus2 in entities.Cursussen2.Include("BoekenCursussen2")
            //                    where cursus2.Naam == "C++"
            //                    select new { Cursus = cursus2, HoogsteVolgnr = cursus2.BoekenCursussen2.Max(x => x.VolgNr) };

            //        var queryResult = query.FirstOrDefault();

            //        if(queryResult != null)
            //        {
            //            entities.BoekenCursussen2.Add(new BoekCursus2 { Boek2 = nieuwBoek, Cursus2 = queryResult.Cursus, VolgNr = queryResult.HoogsteVolgnr + 1 });
            //            entities.SaveChanges();
            //        }
            //        transactionScope.Complete();
            //    }
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from cursist in entities.Cursisten
            //                      where cursist.MentorNr == null
            //                      orderby cursist.Voornaam, cursist.Familienaam
            //                      select cursist;

            //    if (query != null)
            //    {
            //        foreach (var curist in query)
            //        {
            //            Console.WriteLine(curist.Voornaam + ":" + curist.Familienaam);
            //        }
            //    }
            //    Console.ReadLine();
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from cursist in entities.Cursisten.Include("Mentor")
            //                where cursist.MentorNr != null
            //                orderby cursist.Voornaam, cursist.Familienaam
            //                select cursist;

            //    if (query != null)
            //    {
            //        foreach (var curist in query)
            //        {
            //            var mentor = curist.Mentor;
            //            Console.WriteLine("cursist:{0} {1}/ Mentor:{2} {3}", curist.Voornaam, curist.Familienaam, mentor.Voornaam, mentor.Familienaam);
            //        }
            //    }
            //    Console.ReadLine();
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from mentor in entities.Cursisten.Include("Beschermelingen")
            //                where mentor.Beschermelingen.Count > 0
            //                orderby mentor.Voornaam, mentor.Familienaam
            //                select mentor;

            //    if (query != null)
            //    {
            //        foreach (var curist in query)
            //        {
            //            Console.WriteLine("{0} {1}:", curist.Voornaam, curist.Familienaam);
            //            foreach (var beschermeling in curist.Beschermelingen)
            //            {
            //                Console.WriteLine("\t {0} {1}", beschermeling.Voornaam, beschermeling.Familienaam);
            //            }
            //        }
            //    }
            //    Console.ReadLine();
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var cursist5 = entities.Cursisten.Find(5);

            //    if (cursist5 != null)
            //    {
            //        var cursist6 = entities.Cursisten.Find(6);
            //        if (cursist6 != null)
            //        {
            //            cursist5.Beschermelingen.Add(cursist6);
            //            entities.SaveChanges();
            //        }
            //        else
            //            Console.WriteLine("cursist 6 niet gevonden");

            //    }
            //    else
            //        Console.WriteLine("cursist 5 niet gevonden");


            //    Console.ReadLine();
            //}

            //****************************************************************************************
            //using (var entities = new OpleidingenTPCEntities())
            //{
            //    var query = from cursus in entities.TPCCursussen
            //                orderby cursus.Naam
            //                select cursus;

            //    foreach(var cursus in query)
            //        Console.WriteLine("{0} {1}", cursus.Naam, cursus.GetType().Name);

            //    Console.ReadLine();
            //}

            //****************************************************************************************
            //using (var entities = new OpleidingenTPCEntities())
            //{
            //    Console.WriteLine("Voor aanpassing");

            //    var query = from cursus in entities.TPCCursussen
            //                where cursus is TPCZelfstudieCursus
            //                orderby cursus.Naam
            //                select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //    }

            //    entities.TPCCursussen.Add(new TPCZelfstudieCursus { Naam = "Spaanse correpsondentie", Duurtijd = 6 });
            //    entities.SaveChanges();

            //    Console.WriteLine("\nNa aanpassing:");

            //    query = from cursus in entities.TPCCursussen
            //                where cursus is TPCZelfstudieCursus
            //                orderby cursus.Naam
            //                select cursus;

            //    foreach (var cursus in query)
            //    {
            //        Console.WriteLine(cursus.Naam);
            //    }
            //}

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    foreach (var cursist in entities.Cursisten)
            //    {
            //        Console.WriteLine(cursist.Naam.InformeleBegroeting);
            //    }

            //}
            //Console.ReadLine();

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    foreach (var docent in entities.Docenten)
            //    {
            //        Console.WriteLine("{0}:{1}", docent.Naam, docent.Geslacht);
            //    }

            //}
            //Console.ReadLine();

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var query = from grootsteWeddePerCampus
            //                in entities.grootsteWeddePerCampus
            //                orderby grootsteWeddePerCampus.CampusNr, grootsteWeddePerCampus.Voornaam, grootsteWeddePerCampus.Familienaam
            //                select grootsteWeddePerCampus;
            //    var vorigCampusNr = 0;
            //    foreach (var x in query)
            //    {
            //        if(x.CampusNr != vorigCampusNr)
            //        {
            //            Console.WriteLine("{0} {1} Grootste wedde:", x.Naam, x.GrootsteWedde);
            //            vorigCampusNr = x.CampusNr;
            //        }
            //        Console.WriteLine("\t{0} {1}", x.Voornaam, x.Familienaam);
            //    }
            //}
            //Console.ReadLine();

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    foreach (var campus in entities.CampussenVanTotPostCode("8000", "9000"))
            //    {
            //        Console.WriteLine("{0}: {1}", campus.Naam, campus.PostCode);
            //    }
            //}
            //Console.ReadLine();

            //****************************************************************************************
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    foreach (var docent in entities.AantalDocentenPerVoornaam())
            //    {
            //        Console.WriteLine("{0}: {1}", docent.Voornaam, docent.Aantal);
            //    }
            //}
            //Console.ReadLine();

            //****************************************************************************************
            //Console.WriteLine("Opslagpercentage:");
            //decimal percentage;
            //if (decimal.TryParse(Console.ReadLine(), out percentage))
            //{
            //    using (var entities = new EFOpleidingenEntities())
            //    {
            //        var aantalDocentenAangepast = entities.WeddeVerhoging(percentage);
            //        Console.WriteLine("{0} docenten aangepast", aantalDocentenAangepast);
            //    }
            //}
            //else
            //    Console.WriteLine("Tik een getal");
            //Console.ReadLine();

            //****************************************************************************************
            //Console.WriteLine("Familienaam:");
            //var familienaam = Console.ReadLine();
            //using (var entities = new EFOpleidingenEntities())
            //{
            //    var aantalDocenten = entities.AantalDocentenMetFamilienaam(familienaam);
            //    Console.WriteLine("{0} docent(en)", aantalDocenten.First());
            //}
            //Console.ReadLine();
        }

        static void VoorraadTransfer1(int artikelNr, int vanMagazijnNr, int naarMagazijnNr, int aantalStuks)
        {
            using (var entities = new EFOpleidingenEntities())
            {
                var vanVoorraad = entities.Voorraden.Find(vanMagazijnNr, artikelNr);

                if (vanVoorraad != null)
                {
                    if (vanVoorraad.AantalStuks >= aantalStuks)
                    {
                        vanVoorraad.AantalStuks -= aantalStuks;

                        var naarVoorraad = entities.Voorraden.Find(naarMagazijnNr, artikelNr);

                        if (naarVoorraad != null)
                            naarVoorraad.AantalStuks += aantalStuks;
                        else
                        {
                            naarVoorraad = new Voorraad { ArtikelNr = artikelNr, MagazijnNr = naarMagazijnNr, AantalStuks = aantalStuks };
                            entities.Voorraden.Add(naarVoorraad);
                        }
                        entities.SaveChanges();
                    }
                    else
                        Console.WriteLine("Te weinig voorraad voor transfer");
                }
                else
                    Console.WriteLine("Artikel niet gevonden in magazijn" + vanMagazijnNr);
            }
        }

        static void VoorraadTransfer2(int artikelNr, int vanMagazijnNr, int naarMagazijnNr, int aantalStuks)
        {
            var transactionOptions = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead };

            using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                using (var entities = new EFOpleidingenEntities())
                {
                    var vanVoorraad = entities.Voorraden.Find(vanMagazijnNr, artikelNr);

                    if (vanVoorraad != null)
                    {
                        if (vanVoorraad.AantalStuks >= aantalStuks)
                        {
                            vanVoorraad.AantalStuks -= aantalStuks;

                            var naarVoorraad = entities.Voorraden.Find(naarMagazijnNr, artikelNr);

                            if (naarVoorraad != null)
                                naarVoorraad.AantalStuks += aantalStuks;
                            else
                            {
                                naarVoorraad = new Voorraad { ArtikelNr = artikelNr, MagazijnNr = naarMagazijnNr, AantalStuks = aantalStuks };
                                entities.Voorraden.Add(naarVoorraad);
                            }
                            entities.SaveChanges();
                            transactionScope.Complete();
                        }
                        else
                            Console.WriteLine("Te weinig voorraad vor transfer");
                    }
                    else
                        Console.WriteLine("Artikel niet gevonden in magazijn "+ vanMagazijnNr);
                }
            }
        }

        static void VoorraadBijvulling1(int artikelNr, int magazijnNr, int aantalStuks)
        {
            using (var entities = new EFOpleidingenEntities())
            {
                var voorraad = entities.Voorraden.Find(magazijnNr, artikelNr);

                if(voorraad != null)
                {
                    voorraad.AantalStuks += aantalStuks;
                    Console.WriteLine("Pas nu de voorraad aan met de server Explorer, druk daarna op Enter");
                    Console.ReadLine();
                    entities.SaveChanges();
                }
                else
                    Console.WriteLine("Voorraad niet gevonden");
            }
        }

        static void VoorraadBijvulling2(int artikelNr, int magazijnNr, int aantalStuks)
        {
            using (var entities = new EFOpleidingenEntities())
            {
                var voorraad = entities.Voorraden.Find(magazijnNr, artikelNr);

                if (voorraad != null)
                {
                    voorraad.AantalStuks += aantalStuks;
                    Console.WriteLine("Pas nu de voorraad aan met de server Explorer, druk daarna op Enter");
                    Console.ReadLine();
                    try
                    {
                        entities.SaveChanges();
                    }
                    catch(DbUpdateConcurrencyException)
                    {
                        Console.WriteLine("Voorraad werd door een andere applicatie aangepast.");
                    }
                }
                else
                    Console.WriteLine("Voorraad niet gevonden");
            }
        }
    }
}
