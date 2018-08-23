using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EFTestV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.Serializable
            };
            using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                using (var entities = new EFLandenStedenTalenEntities())
                {
                    //***Toon een lijst van landen, gesorteerd op naam****
                    Console.WriteLine("Toon een lijst van landen, gesorteerd op naam");
                    List<Landen> landenList = (from Landen in entities.Landen.Include("Talen").Include("Steden")
                                               orderby Landen.Naam
                                               select Landen).ToList();


                    foreach (var land in landenList)
                    {
                        Console.WriteLine("\t{0}", land.Naam);
                    }

                    //******Toon per land de landcode en naam******
                    Console.WriteLine();
                    Console.WriteLine("Toon per land de landcode en naam");
                    foreach (var land in landenList)
                    {
                        Console.WriteLine("\t{0} - {1}", land.Naam, land.LandCode);
                    }

                    //******De Gebruiker tikt een landcode in******
                    Console.WriteLine();
                    Console.WriteLine("Tik een landcode in");
                    string gekozenLandcode = Console.ReadLine();

                    //******Toon lijst van namen van steden in dat land, gevolgd door een lijst van de namen van talen gesproken in dat land****
                    //Landen gelinkteLand = landenList.Find(x => x.LandCode == gekozenLandcode);
                    Landen gelinkteLand = entities.Landen.Find(gekozenLandcode);
                    if (gelinkteLand != null)
                    {
                        Console.WriteLine("Lijst steden van {0} - {1}", gelinkteLand.LandCode, gelinkteLand.Naam);
                        foreach (var steden in gelinkteLand.Steden)
                        {
                            Console.WriteLine("\t{0}", steden.Naam);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Lijst talen");
                        foreach (var talen in gelinkteLand.Talen)
                        {
                            Console.WriteLine("\t{0}", talen.Naam);
                        }

                        //****De gebruiker tikt de naam van een stad in om toe te voegen*******
                        Console.WriteLine();
                        Console.WriteLine("Tik de naam van een stad in om toe te voegen");
                        string newStadNaam = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newStadNaam))
                        {
                            if (gelinkteLand.Steden.Where(x => x.Naam == newStadNaam).Count()== 0)
                            {
                                Steden newStad = new Steden
                                {
                                    Naam = newStadNaam
                                };

                                //Als bijhorende land, het land dat de gebruiker gekozen heeft*******
                                gelinkteLand.Steden.Add(newStad);
                                entities.SaveChanges();
                                transactionScope.Complete();
                                Console.WriteLine("{0} toegevoegd", newStadNaam);
                            }
                            else
                                Console.WriteLine("{0} is al eerder toegevoegd aan de database", newStadNaam);
                        }
                        else
                            Console.WriteLine("Geen geldige stad");
                    }
                    else
                        Console.WriteLine("Geen land gevonden met landcode: {0}", gekozenLandcode);                  
                }//Einde using(var entities...)
            }//Einde using( transactionScope...)
            Console.ReadLine();
        }
    }
}
