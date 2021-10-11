using System;
using System.Text;

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

            string input = "Hallo Welt";

            foreach (char currentChar in input)
            {
                Console.WriteLine(currentChar);

                if (char.IsLetter(currentChar))
                {
                    if( currentChar == 'A')
                    {
                        Console.WriteLine("Buchstabe ist ein A");
                    }
                }
            }
            #endregion

            #region Nummerische Datentypen (Ganzzahlen)
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/built-in-types

            // Boolische Logik (vorab) 
            bool trueOrFalse = true;
            trueOrFalse = false;

            //Byte 255 
            byte minByte = byte.MinValue; // von 0
            byte maxByte = byte.MaxValue; // bis 255


            //16 Bit
            short minShort = short.MinValue; //von -32k
            short maxShort = short.MaxValue; //bis 32k 

            ushort uMinShort = ushort.MinValue; // 0
            ushort uMaxShort = ushort.MaxValue; //65k

            //32 Bit - Integer
            int minInt = int.MinValue; //-2Mrd
            int maxInt = int.MaxValue; //+2Mrd

            //64 Bit long
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            #endregion

            #region Gleitkomma Zahlen
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

            double doubleValue = 65.55;

            float floatValue = 12.344f;

            decimal moneyValue = 199.99m;



            #endregion


            #region Datentypen in C# UND Datentypen in .NET 

            int zahlDesTages = 123; // C# Datentyp

            Int32 zahlDesTages1 = 123; // Native Datentyp in .NET

            String str = "Halli Hallo";
            string theBetterCSharpString = "123 Yeees";


            #endregion


            #region Nullbare Wertetypen

            int meineZahl; //Wert 0 

            //Wie können wir sagen, dass eine Integer-Variable (null) ist -> einen Zustand vor der Initialisierung
            int? meineNullableZahl = null;

            //ist Variable == null
            if (meineNullableZahl.HasValue)
            {
                Console.WriteLine(meineNullableZahl.Value); //Ausgabe einer Nullbaren Variable mit der Property Value
            }

            //Alternative Schreibweise
            if (meineNullableZahl == null)
            {
                //selbe Abfrage wie HasValue
            }
            //Compiler Warnoing -> https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0219?f1url=%3FappId%3Droslyn%26k%3Dk(CS0219) 
            //Variable wurde nicht ein weiteres mal verwendet. 
            decimal? nullableDecimal = null;
            float? nullableFloat = null;
            double? nullableDouble = null;

            long? nullableLong = null; //nullableLong wird 2x verwenden, daher keine Warnung -> CS0219
            byte? nullableByte = null;

            bool? nullableBoolean = null;

            Console.WriteLine(nullableLong.Value);
            

            ///Und wie ist es bei Strings? 
            string testMyContent = "123ABC";

            if(string.IsNullOrEmpty(testMyContent))
            {
                Console.WriteLine("string ist null oder enthält keine Zeichen");
            }
            else if(string.IsNullOrWhiteSpace(testMyContent))
            {
                Console.WriteLine("string ist null oder enthält Leerzeichen");
            }

            #endregion

            #region Extention zu char/string

            char A = 'A';
            char B = 'B';
            char C = 'C';

            string abc = (Convert.ToString(A) + Convert.ToString(B) + Convert.ToString(C));
            string def = A.ToString() + B.ToString() + C.ToString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("1.");
            stringBuilder.Append(" ");
            stringBuilder.Append("Union ");
            stringBuilder.Append("Berlin");

            Console.WriteLine(stringBuilder.ToString());

            for (int i = 0; i < def.Length; i++)
            {
                char currentChar = def[i];
            }

            #endregion
        }
    }
}
