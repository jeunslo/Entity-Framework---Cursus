using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace EFTaak01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taak 02:Klanten en hun rekeningen*******************************************************************
            //var klantInfo = GetKlant();
            //foreach (var info in klantInfo)
            //{
            //    Console.WriteLine(info.Voornaam);
            //    decimal totaal = 0m;
            //    if (info.Rekeningen != null)
            //    {
            //        foreach (var rekening in info.Rekeningen)
            //        {
            //            Console.WriteLine(rekening.RekeningNr + ":" + rekening.Saldo);
            //            totaal += rekening.Saldo;
            //        }
            //    }
            //    Console.WriteLine("Totaal:" + totaal);
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Taak03: Zichtrekening toevoegen*******************************************************************
            //using (var entities = new EFBankEntities())
            //{
            //    foreach (var info in entities.Klanten.OrderBy(x => x.Voornaam).ToList())
            //        Console.WriteLine(info.KlantNr + ":" + info.Voornaam);
            //    Console.WriteLine("KlantNr:");
            //    try
            //    {
            //        if (int.TryParse(Console.ReadLine(), out int GekozenKlantNr))
            //        {
            //            var klant1 = entities.Klanten.Find(GekozenKlantNr);
            //            if (klant1 == null)
            //                Console.WriteLine("Klant niet gevonden");
            //            else
            //            {
            //                Console.WriteLine("Voer een zichtrekening toe:");
            //                var zichtRekeningNr = Console.ReadLine();
            //                var zichtRekening = new Rekening { RekeningNr = zichtRekeningNr, Saldo = 0m, Soort = "Z" };
            //                klant1.Rekeningen.Add(zichtRekening);
            //                entities.SaveChanges();
            //            }
            //        }
            //        else
            //            Console.WriteLine("Tik een getal");
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //Taak04:Storten*******************************************************************
            //using (var entities = new EFBankEntities())
            //{
            //    Console.Write("Geef rekeningsNr:");
            //    var rekening = entities.Rekeningen.Find(Console.ReadLine());

            //    if(rekening != null)
            //    {
            //        Console.Write("Geef te storten bedrag:");
            //        bool boolTest = false;
            //        while (boolTest == false)
            //        {
            //            decimal bedrag = 0;
            //            while (!decimal.TryParse(Console.ReadLine(), out bedrag))
            //            {
            //                Console.WriteLine("Tik een getal");
            //            }
            //            if(bedrag <= 0)
            //            {
            //                Console.WriteLine("Tik een positief getal");
            //            }
            //            else
            //            {
            //                rekening.Storten(bedrag);
            //                entities.SaveChanges();
            //                boolTest = true;
            //            }
            //        }       
            //    }
            //    else
            //        Console.WriteLine("Rekening niet gevonden");
            //}

            //Console.ReadLine();

            //Taak05:Klant Verwijderen*******************************************************************
            //using (var entities = new EFBankEntities())
            //{
            //    Console.Write("Geef klantennummer:");
            //    int klantNr = 0;
            //    while(!int.TryParse(Console.ReadLine(), out klantNr))
            //    {
            //        Console.WriteLine("Tik een getal");
            //    }
            //    var klant = entities.Klanten.Find(klantNr);
            //    if(klant != null)
            //    {
            //        if(klant.Rekeningen.Count <= 0)
            //        {
            //            entities.Klanten.Remove(klant);
            //            entities.SaveChanges();
            //        }
            //        else
            //            Console.WriteLine("Klant heeft nog rekeningen");
            //    }
            //    else
            //        Console.WriteLine("Klant niet gevonden");
            //}
            //Console.ReadLine();

            //Taak06: Overschrijven*******************************************************************

            //Console.WriteLine("van rekeningsnummer:");
            //var vanRekeningsNr = Console.ReadLine();

            //Console.WriteLine("naar rekeningsnummer:");
            //var naarRekeningsNr = Console.ReadLine();

            //Console.WriteLine("te storten bedrag:");
            //decimal bedrag = 0m;
            //bool testBool = false;
            //while (testBool == false)
            //{
            //    while (!decimal.TryParse(Console.ReadLine(), out bedrag))
            //    {
            //        Console.WriteLine("Tik een getal");
            //    }
            //    if (bedrag <= 0)
            //        Console.WriteLine("Tik een positief getal");
            //    else
            //        testBool = true;
            //}
            //try
            //{
            //    OverschrijvenTransaction(vanRekeningsNr, naarRekeningsNr, bedrag);
            //}
            //catch(SaldoOntoereikendException)
            //{
            //    Console.WriteLine("Saldo ontoereikend");
            //}

            //Console.ReadLine();

            //Taak07:Klant wijzigen*******************************************************************
            //try
            //{
            //    Console.Write("Klantnummer:");
            //    if (!int.TryParse(Console.ReadLine(), out int klantNr))
            //        throw new Exception("Tik een getal");

            //    using (var entities = new EFBankEntities())
            //    {
            //        var klant = entities.Klanten.Find(klantNr);

            //        if (klant != null)
            //        {
            //            Console.Write("Gecorrigeerde naam:");
            //            klant.Voornaam = Console.ReadLine();
            //            try
            //            {
            //                entities.SaveChanges();
            //            }
            //            catch (DbUpdateConcurrencyException)
            //            {
            //                Console.WriteLine("Een andere gebruiker wijzigde deze klant");
            //            }
            //        }
            //        else
            //            throw new Exception("Klant niet gevonden");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Taak08:Personeel*******************************************************************
            //using (var entities = new EFBankEntities())
            //{
            //    var query = (from personeel in entities.Personeel.Include("Personeelsleden")
            //                where personeel.ManagerNr == null
            //                select personeel).ToList();

            //    SelfLoop(query, 0);

            //}
            //Console.ReadLine();

            //Taak09:Zichtrekeningen - Spaarrekeningen*******************************************************************
            //using (var entities = new EFBankEntities())
            //{
            //    var query = from x in entities.Rekeningen
            //                where x is Zichtrekening
            //                select x;

            //    foreach (var zichtrekening in query)
            //    {
            //        Console.WriteLine("{0} - {1}", zichtrekening.RekeningNr, zichtrekening.Saldo);
            //    }
            //}
            //Console.ReadLine();

            //Taak10:Totale Saldo Per Klant*******************************************************************
            //using (var entities = new EFBankEntities())
            //{
            //    var query = from x in entities.TotaleSaldoPerKlant
            //                orderby x.Voornaam
            //                select x;

            //    foreach (var klant in query)
            //    {
            //        Console.WriteLine("{0} : {1}", klant.Voornaam, klant.TotaleSaldo);
            //    }
            //}

            //Taak11:Administratieve Kost*******************************************************************
            Console.WriteLine("Hoeveel bedraagt de kost?");
            if(decimal.TryParse(Console.ReadLine(), out decimal kost))
            {
                using (var entities = new EFBankEntities())
                {
                    var aantalAangepast = entities.AdministratieveKost(kost);
                    Console.WriteLine("aantal aangepaste rekeningen:{0}", aantalAangepast);
                }
            }
            else
                Console.WriteLine("Tik een getal");
            Console.ReadLine();

        }

        static void SelfLoop(List<Personeelslid> x, int multiplier)
        {           
            string tekst = new string('\t', multiplier);

            foreach (var lager in x)
            {
                Console.WriteLine(tekst + lager.Voornaam);
                if (lager.Personeelsleden.Count > 0)
                {
                    SelfLoop(lager.Personeelsleden.ToList(), multiplier + 1);
                }
            }
        }

        static List<Klant> GetKlant()
        {
            using (var entities = new EFBankEntities())
            {
                return (from klanten in entities.Klanten.Include("Rekeningen")
                        orderby klanten.Voornaam
                        select klanten).ToList();              
            }
        }

        static void OverschrijvenTransaction(string vanRekeningNr, string naarRekeningNr, decimal bedrag)
        {
            var transactionOptions = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead };

            using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                using (var entities = new EFBankEntities())
                {
                    var vanRekening = entities.Rekeningen.Find(vanRekeningNr);
                    if(vanRekening != null)
                    {
                        var naarRekening = entities.Rekeningen.Find(naarRekeningNr);
                        if(naarRekening != null)
                        {
                            vanRekening.Overschrijven(naarRekening, bedrag);
                        }
                        else
                            Console.WriteLine("Naar-rekening niet gevonden");
                    }
                    else
                        Console.WriteLine("Van-rekening niet gevonden");
                    Console.ReadLine();
                    entities.SaveChanges();
                }
                transactionScope.Complete();
            }
        }
    }
}
