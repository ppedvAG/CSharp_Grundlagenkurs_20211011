using System;

namespace M002_01_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Datentypen

            //char -> Ein Zeichen
            char letter = 'A';
            Console.WriteLine(letter);

            if(char.IsLetter(letter))
            {
                Console.WriteLine("Es wurde ein Buchstabe eingegeben");
            }
            else if (char.IsNumber(letter))
            {
                Console.WriteLine("Es wurde ein Nummer eingegeben");
            }
            else if (char.IsDigit(letter))
            {
                Console.WriteLine("Es wurde ein 'Decimal digit' eingegeben");
            }


            #region Zeichenketten mit string

            string stringWithEscapes = "Hallo\nLiebe\nTeilnehmer\n";

            string pfad = "C:\\Windows\\Temp";
            string bessererPfad = @"C:\Windows\Temp\"; // @ - Zeichen wird für das Darstellen von Windowspfaden verwendet. 

            //schlechteste Art eine Variable + statischen Text auszugeben ist.....
            string output1 = "Verzeichnisausgabe: " + bessererPfad; //Pluszeichen ist bei string-Verkettungen sehr böse

            Console.WriteLine("Verzeichnisausgabe: {0}", bessererPfad); //Ein Erbe aus C -> printf ("statischen Text {0}, {1}, {3}", variable1, variable2, var3);

            Console.WriteLine($"Verzeichnisausgabe: {bessererPfad}");

            Console.WriteLine(bessererPfad);
            #endregion                     

        }
    }
}
