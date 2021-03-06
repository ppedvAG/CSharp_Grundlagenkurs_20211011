using System;
using System.Linq;

namespace M001_01_BoolischeLogikl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convert Zahl <-> Boolean Ausdruck
            bool booleanWahr = true;
            bool booleanFalsch = false;

            // aus True wird 1
            // aus False wäre 0
            int result1 = Convert.ToInt32(booleanWahr);
            int result2 = Convert.ToInt32(booleanFalsch);

            int number1 = 1;
            int number2 = 0;

            //aus 1 wird True
            //aus 0 wird False
            bool boolValue = Convert.ToBoolean(number1);
            bool boolValue1 = Convert.ToBoolean(number2);
            #endregion




             
            bool ergebnis1 = booleanWahr == booleanFalsch; //sind beide Ausdrücke gleich -> False
            bool ergebnis2 = booleanWahr != booleanFalsch; //sind beide Ausdrücke ungleich -> True
            bool ergebnis3 = number1 == number2; // number1=1 und number2 = 0 -> beide sind ungleich
            bool ergebnis4 = number2 != number1; // Da beide Ungleich sind, wird True zurück gegeben
            

            string ersterString = "Inhalt des Strings";
            string zweiterString = "Inhalt des Strings";
            bool ergebnis5 = ersterString == zweiterString; //true
            bool ergebnis6 = ersterString != zweiterString; //false


            //Vergleichsoperatoren (kleiner, groesser, kleiner-gleich, groesser-gleich)
            bool ergebnis7 = number1 < number2; //false
            bool ergebnis8 = number1 > number2; //true

            bool ergebnis9 = number1 <= number2; //false
            bool ergebnis10 = number1 >= number2; //true

            bool ergebnis11 = number1 >= number2; //true
            bool ergebnis12 = number1 <= number2; //false


            //bedingte logische Operatoren (und, oder)
            //bedingte logische Operatoren (und, oder)
            bool ergebnis13 = booleanWahr && booleanFalsch; //false -> es müssen beide Ausdrücke true sein 
            bool ergebnis14 = booleanWahr || booleanFalsch; //true


            //logische Operatoren (und, oder, exklusiv oder)
            bool ergebnis15 = booleanWahr & booleanFalsch; //false
            bool ergebnis16 = booleanWahr | booleanFalsch; //true
            bool ergebnis17 = booleanWahr ^ booleanFalsch; //true
            bool ergebnis17a = booleanFalsch ^ booleanWahr; //true
            bool ergebnis18 = booleanWahr ^ booleanWahr; //false
            bool ergebnis19 = booleanFalsch ^ booleanFalsch; //false

            /*    AND
             *    Ausdruck1     |       Ausdruck2   |   Ausgabe
             *    true          |       true        |   true
             *    true          |       false       |   false
             *    false         |       false       |   false
             *   
             *   OR
             *   Ausdruck1      |       Ausdruck2   |   Ausgabe
             *   true           |       true        |   true
             *   true           |       false       |   true
             *   false          |       true        |   true
             *   false          |       false       |   false
             *   
             *   
             *   XOR
             *   Ausruck1       |       Ausdruck2   |   Ausgabe
             *   true           |       true        |   false
             *   true           |       false       |   true
             *   false          |       true        |   true
             *   false          |       false       |   false
             */


            string howMuchLetter = "ABCDEFGkjdfgldsbfgl";
            Console.WriteLine(howMuchLetter.Length); //direkte ausgabe 

            Console.WriteLine(howMuchLetter.Count()); //Linq->Count -> Hier beginnt er zuerst mit der ermittlung.... 
        }
    }
}
