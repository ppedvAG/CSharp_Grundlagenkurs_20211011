using System;

namespace M002_03_ParsenCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region int/double <-> string
            //https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/types/casting-and-type-conversions

            #region int -> string
            int lottozahlen = 1234567;

            //ToString(); Explizietes Casten auf ein String
            Console.WriteLine(lottozahlen.ToString());

            //Implizietes Casten
            Console.Write(lottozahlen); //Intern wird ToString() verwendet 
            #endregion
            #region double->string
            double pi = 3.14;

            
            Console.WriteLine(pi);
            Console.WriteLine(pi.ToString());
            #endregion


            #region string -> int
            string zahlenEingabe = "12345";

            //Konventieren -> Im Grunde wir hier trotzem geparst. 
            int parsedIntegerValue = Convert.ToInt32(zahlenEingabe);
            int parsedIntegerValue2 = int.Parse(zahlenEingabe);

            //Er prüft ob der String überhaupt als Zahl gelten darf (sind buchstaben oder sonderzeichen enthalten) 
            int parsedIntegerValue3;
            
            if (int.TryParse(zahlenEingabe, out parsedIntegerValue3))
            {
                //Innerhalb dieser if-Anweisung kann parsedIntegerValue3 als integer-value verwendet werden
            }

            //int testValue = (int)zahlenEingabe; -> Das geht nur bei Zuweisungen und Casten von Zahlen-Datentypen
            #endregion
            #region string->double
            string piAsString = "3.14";

            double myPiValue = Convert.ToDouble(piAsString);
            double myPiValue1 = double.Parse(piAsString);

            #endregion
            #endregion



            #region int -> double 

            int myNumber = 123;
            double myDoubleNumber = myNumber; //Implizietes Casting


            double myPi = 3.14;

            //Kommawerte werden abgeschnitten
            int test = Convert.ToInt32(myPi);
            int test1 = (int)myPi; // Wert hinter dem Komma wird nicht übertragen (abgeschnitten) 

            long statValue = 123456789;
            short myLitteNumber = (short)statValue;
            #endregion
        }
    }
}
