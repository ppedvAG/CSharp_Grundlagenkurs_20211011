using System;
using System.Collections.Generic;

namespace M008_01_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Beispiel Lebewesen
            Lebewesen lebewesen = new Lebewesen(22);
            int Alter = lebewesen.Alter;
            lebewesen.Essen();


            Mensch mensch = new Mensch(33, "Hamburg");
            int menschAlter = mensch.Alter;
            mensch.Essen();
            mensch.Schreiben();
            mensch.Sprechen();
            mensch.Wohnort = "Hamburg";

            Vogel vogel = new Vogel();
            vogel.Essen();
            //vogel.Alter;
            vogel.Fliegen();
            vogel.Zwitschern();
            vogel.LegeEinEi();
            #endregion


            #region Wann machen wir Vererbung
            Girokonto girokonto = new Girokonto(1100, -2000);
            Sparbuch sparbuch = new Sparbuch(4000, 3);
            #endregion


            #region Listen und Polymorphie
            List<Account> accountLost = new List<Account>();
            accountLost.Add(girokonto);
            accountLost.Add(sparbuch);

            #endregion


            #region Documents 

            PDF pdf = new PDF();
            pdf.PrintDocument();
            pdf.RockMeAmadeus();

            CSVDocument csvDoc = new CSVDocument();
            csvDoc.PrintDocument();
            csvDoc.RockMeAmadeus();

            List<DocumentObject> docList = new List<DocumentObject>();
            docList.Add(pdf);
            docList.Add(csvDoc);


            foreach (DocumentObject currentDoc in docList)
            {
                currentDoc.PrintDocument(); //Virtual Methode vs 
                currentDoc.RockMeAmadeus(); //Normale Methode
            }


            #endregion

        }
    }
}
