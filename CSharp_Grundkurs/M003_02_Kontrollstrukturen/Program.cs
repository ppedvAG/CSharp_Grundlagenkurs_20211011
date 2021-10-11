using System;

namespace M003_02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {

            #region if / else if / else
            Console.Write("Gebe bitte den Akkustand ein: ");

            int akkuStand = int.Parse(Console.ReadLine());

            //Ausgeschrieben würde das so aussehen:
            //string input = Console.ReadLine();
            //akkuStand = int.Parse(input);

            string akkuStatus = string.Empty; //akkuStand = ""; 


            //If-Statement mit einer ausführbaren Codezeile
            if (akkuStand > 20 && akkuStand <= 100)
                akkuStatus = "Akku ist in Ordnung";


            //If-Statement mit einem ausführbaren Body -> { ..... } zwischen den geschweiften Klammern, können wir mehrere Codezeile implementieren
            if (akkuStand > 20 && akkuStand <= 100)
            {
                akkuStatus = "Akku ist in Ordnung";
                //.... weitere Codezeilen einbinden 
            }
            else if (akkuStand > 0 && akkuStand <= 20)
            {
                akkuStatus = "Akku sollte geladen werden";
            }
            else if (akkuStand == 0)
            {
                akkuStatus = "Akku ist leer";
            }
            else
            {
                akkuStatus = "Akku ist defekt";
            }

            Console.WriteLine($"Akkustand: {akkuStatus} ");
            #endregion


            #region Inline If-Statement
            int myNumber = 33;
            //Kurzschreibform
            bool result = myNumber == 33 ? true : false;
            string output = myNumber == 33 ? "Zahl ist 33" : "Zahl ist nicht 33";
            #endregion


            #region switch Struktur

            DateTime dateTime = new DateTime(2003, 7, 7);
            string returnDayAsString = string.Empty;


            //Welcher Wochentag fällt auf den 7.7.2003? 
            switch (dateTime.DayOfWeek)
            { 
                case DayOfWeek.Monday:
                    returnDayAsString = "Montag";
                    //break muss verwendet werden, damit wir switch verlassen + nicht die darunter liegende Implementierung ausführt. 
                    break;
                case DayOfWeek.Tuesday:
                    returnDayAsString = "Dienstag";
                    break;
                case DayOfWeek.Wednesday:
                    returnDayAsString = "Mittwoch";
                    break;
                case DayOfWeek.Thursday:
                    returnDayAsString = "Donnerstag";
                    break;
                case DayOfWeek.Friday:
                    returnDayAsString = "Freitag";
                    break;
                default: //Repräsentiert den Samstag und Sonntag 
                    returnDayAsString = "Wochenende";
                    break;
            }

            //Welcher Wochentag fällt auf den 7.7.2003? 

            bool isArbeitstag = false;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    isArbeitstag = true;
                    break;
                default: //Repräsentiert den Samstag und Sonntag 
                    isArbeitstag = false;
                    break;
            }

            Console.WriteLine($"Ist der {dateTime.ToShortDateString()} ein Arbeitstag? -> {isArbeitstag.ToString()}");
            #endregion

            #region Alternatives Beispiel zu, welchen Wochentag fällt auf das Datum X

            Console.Write("Gebe Obst ein: ");
            string obst = Console.ReadLine();
            string farbe = string.Empty;

            switch (obst)
            {
                case "Kirsche":
                    farbe = "rot";
                    break;
                case "Banane": //wenn obst == "Banane" die kommende Anweisung ausfuehren
                case "Zitrone":
                    farbe = "gelb";
                    break;
                case "Orange":
                    farbe = "orange";
                    break;
                default:
                    farbe = "unbekannt";
                    break;
            }

            #endregion

        }
    }
}
