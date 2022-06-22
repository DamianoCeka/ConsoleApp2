using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Quantità giacenza 

            // Negozio e aggragati
            negozio ITtech = new negozio();
            orari Orari = new orari();
            magazzino Magazzino = new magazzino();


            Console.WriteLine( " Salve i nostri orari Sono:" + Orari._apertumattina +" / "+  Orari._aperturaPomeriggio + " e Dalle " + Orari._aperturaPomeriggio + " / " + Orari._chiusuraPomeriggio);
            Console.WriteLine(" I Nostri prodotti : " + ITtech.AcerNitro + " / " + ITtech.AppleMacboock + " / " + ITtech.AsusRog + " / " + ITtech.msi);
            Console.WriteLine(" le nostre giacenze sono rispettivamente :" + ITtech.AcerNitro + " Quantita : " + Magazzino.AcerNitro + " / " + ITtech.AppleMacboock + " Quantita : " + Magazzino.AppleMacboock + " / " + ITtech.AsusRog + " Quantita : " + Magazzino.AsusRog + " / " + ITtech.msi + " Quantita : " + Magazzino.msi + " / ");
            Console.ReadLine();
            Console.Read();
        }

        public class negozio // nome del negozio ITtech
        {
            // marche di pc 
            public string AppleMacboock = "AppleMacboock";
            public string AsusRog = " Asus Rog ";
            public string AcerNitro = "acer Nitro";
            public string msi = " Msi Gaming ";


        }
        public class orari  : negozio // orari e scritto Orari
        {
            public int _apertumattina = 8;
            public int _chiusuraMattina = 13;
            public int _aperturaPomeriggio = 15;
            public int _chiusuraPomeriggio = 19;

        }

        public class magazzino : negozio // magazzino e scritto Magazzino
        {
            public new int AppleMacboock = 20;
            public new int AsusRog = 21;
            public new int AcerNitro = 22;
            public new int msi = 23;
        }
     
    }
   // note
   // Members 
   // string _name
   // int _age
   // String _ codice fiscalel

    // Propertis 
    // Public string Name (lettera maiscuola sul nome) { get { return _name ; }}
    // public int Age ( idem come sopra ) { get { return _age ;  } }
    // public string CodiceFiscale { get { return _codicefiscale ; } }
}



