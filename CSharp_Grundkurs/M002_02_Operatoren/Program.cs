using System;

namespace M002_02_Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //einfache Rechenoperatoren
            int zahl1 = 4;
            int zahl2 = 2;

            //Rechengrundarten
            int addition = zahl1 + zahl2;
            int substraktion = zahl1 - zahl2;
            int multiplikation = zahl1 * zahl2;
            int division = zahl1 / zahl2;


            int zahl3 = 40;
            int zahl4 = 7;

            // 40 / 7 = 35 Rest: 5 -> (RestWert (5) wird verwendet und und stellt das Ergebnis) 
            int modulo = zahl3 % zahl4;

            Random rd = new Random();

            int result = rd.Next(); //0 bis 2147483647

            //21474 / 100 = 214 REST: 74    -> 74
            int zahlZwischen0und100 = result % 100;




            #region Kurzschreibwweise
            int addition1 = 111;
            //wir erhöhen 111 um den Wert -> zahlZwischen0und100
            addition1 = addition1 + zahlZwischen0und100;

            //kurzschreibweise += mit unbekannter Zahl
            addition1 += zahlZwischen0und100;
            #endregion

            #region Inkrementieren -> Wenn Zahl um den Wert 1 erhöht wird

            addition1++;  //Diese Zahl wird um den Wert 1 erhöht
            addition--; //Diese Zahl wird um den Wert 1 verringert. 

            //Kleines Fallbeispiel zu Inkrementierung 
            int age1 = 17;
            
            int age2 = 17;
            //Hier wird Variable ausgegeben und danach um den Wert 1 erhöht
            Console.WriteLine($"Age1 hat bei der Initialisierung den Wert 17 - {age1++}");
            //Hier wird um den Wert 1 erhöht und dnach die Variable ausgegeben 
            Console.WriteLine($"Age2 hat bei der Initialisierung den Wert 17 - {++age2}");

            #endregion

            #region Runden von Gleitkomma-Zahlen
            double myRoundedDoubleValue = Math.Round(4.51); //kaufm. Runden

            double myCeilingRounding = Math.Ceiling(4.14); // -> 5 wird ausgegeben (es wird immer hoch gerundet) 
            double myFloorRounding = Math.Floor(4.95); //-> 4 wird immer abgerundet 


            decimal kommaRundun = decimal.Round(3.156m, MidpointRounding.ToEven);



            #endregion

            //Wir runden ab einer gewissen Kommastelle:

            decimal decimalA = 1.994444m;
            decimal myRoundedDoubleValue2 = Math.Round(decimalA, 2);



            #region for-Schleife auf Komma-Ebene
            for (decimal value = 100m; value <= 102m; value += .1m)
            {
                //0.1 - Schritten 
                Console.WriteLine("{0} --> {1}", value, decimal.Round(value));
            }

            // The example displays the following output:
            //     100 --> 100
            //     100.1 --> 100
            //     100.2 --> 100
            //     100.3 --> 100
            //     100.4 --> 100
            //     100.5 --> 100
            //     100.6 --> 101
            //     100.7 --> 101
            //     100.8 --> 101
            //     100.9 --> 101
            //     101.0 --> 101
            //     101.1 --> 101
            //     101.2 --> 101
            //     101.3 --> 101
            //     101.4 --> 101
            //     101.5 --> 102
            //     101.6 --> 102
            //     101.7 --> 102
            //     101.8 --> 102
            //     101.9 --> 102
            //     102.0 --> 102

            Console.WriteLine(" ##### Bitte drücken Sie eine Taste #####");
            Console.ReadKey();
            Console.Clear();

            for (decimal value = 100m; value <= 105m; value += .1m)
            {
                //0.1 - Schritten 
                //Console.WriteLine("{0} --> {1}", value, Math.Round(value));
                Console.WriteLine("{0} --> {1}", value, Math.Round(value, 0, MidpointRounding.AwayFromZero));
            }

            Console.WriteLine("Gegenprüfung");
            double mycheckNumber = 101.5; // -> 102
            double mycheckNumber2 = 102.5;// -> 103

            Console.WriteLine(Math.Round(mycheckNumber)); //kaufm. Runden
            Console.WriteLine(Math.Round(mycheckNumber2)); //kaufm. Runden
            #endregion

            
        }
    }
}
