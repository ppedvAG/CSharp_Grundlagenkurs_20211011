using System;
using System.Linq;

namespace M004_01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region einfaches Array + Methoden
            //[0..4] Index
            int[] zahlen = new int[5]; //ein leeres Array von der Länge 5 
            zahlen[0] = default(int); ///Gebe mir den Defaultwert für ein Integer 

            //Indexübersicht zu einem Array
            zahlen[0] = 1; //Index 0 -> Start-Index Wert
            zahlen[1] = 2;
            zahlen[2] = 3;
            zahlen[3] = 4;
            zahlen[4] = 5; //Index 4 -> End-Index Wert 
                           //zahlen[5] -> OutOfRangeException (6te Element gib es nicht) 


            string[] woerter = new string[] { "ppedv", "CSharp", "Grundkurs" }; //eine string-Array mit einer Laenge von drei

            //Wie weit kann mein ein Array funktional verwendet 
            double[] gleitkommzahlen = new double[] { 6.29, 1.58, 4.79, 6.55 };
            double result = gleitkommzahlen.Sum(); //sum -> System.Linq;
            double average = gleitkommzahlen.Average(); //average -> System.Linq;
            int anzahlDerArrayFelder = woerter.Length;
            //Min/Max -> benötigt System.Linq;
            double kleinsteZahl = gleitkommzahlen.Min(); //kleinster Wert im Array wird herausgegeben
            double hoechsteZahle = gleitkommzahlen.Max();
            double durschnittsWert = gleitkommzahlen.Average();
            double ersteZahl = gleitkommzahlen.First();
            double letzteZahl = gleitkommzahlen.Last();
            double sum1 = gleitkommzahlen.Sum();

            bool isAvailable = woerter.Contains("ppedv"); //Wenn opedv im Array verfügbar ist, wird true zurück gegeben. 

            //CSV Parsen mit Split 
            string csvPattern = "Kevin;Winter;Berlin;Trainer";
            string[] csvParts = csvPattern.Split(';');
            string vorname = csvParts[0];
            string nachname = csvParts[1];
            string ort = csvParts[2];
            string job = csvParts[3];
            #endregion


            #region ZweiDimensionales Array

            int[,] zweiDimensionalesArray; //Definition 

            zweiDimensionalesArray = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            
            
            //zweidimensionale Array mit vier Zeilen und drei Spalten
            zweiDimensionalesArray = new int[4, 3];
            zweiDimensionalesArray[0, 0] = 22;
            zweiDimensionalesArray[0, 1] = 33;
            zweiDimensionalesArray[0, 2] = 44;

            zweiDimensionalesArray[1, 0] = 22;
            zweiDimensionalesArray[1, 1] = 44;
            zweiDimensionalesArray[1, 2] = 66;


            zweiDimensionalesArray[2, 0] = 3;
            zweiDimensionalesArray[2, 1] = 6;
            zweiDimensionalesArray[2, 2] = 9;

            zweiDimensionalesArray[3, 0] = 7;
            zweiDimensionalesArray[3, 1] = 14;


            #endregion

            #region Dreidimensionales Array
            int[,,] array3D = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };

            int dimensionen = array3D.Rank; //3 -> Anzahl der Dimensionen [2,3,2]
            int anzahlAllerElemente = array3D.Length;

            //Laenge der einzelnen Dimensionen

            int laenge1 = array3D.GetLength(0); //2
            int laenge2 = array3D.GetLength(1); //3
            int laenge3 = array3D.GetLength(2); //2
            #endregion

            #region Initialisierung eines verzweigten Arrays
            int[][] verzweigteArray = new int[4][];

            //
            verzweigteArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 } };

            //Zugriff ueber Index
            int jaggedWert = verzweigteArray[0][2];// 3

            //Zuweisung ueber Index
            verzweigteArray[1][1] = 5;
            #endregion
        }
    }
}
