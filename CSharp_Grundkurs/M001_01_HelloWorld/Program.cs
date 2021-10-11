using System;

namespace M001_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write vs. WriteLine
            // escape-sequences -> https://docs.microsoft.com/de-de/cpp/c-language/escape-sequences?view=msvc-160
            Console.Write("Hallo Liebe Teilnehmer -> " + Environment.NewLine);
            Console.Write("Ich hoffe der Kurs wird allen viel Spass bringen \t und Alle lernen viel \n"); //Zeilenumbruch fehlt

            Console.WriteLine("Hallo Liebe Teilnehmer -> ");
            Console.WriteLine("Ich hoffe der Kurs wird allen viel Spass bringen und Alle lernen viel");

            //Console.ReadLine Sample -> Readline: Eingabe von mehreren Zeichen + [Enter] Taste zum abschließen der Eingabe
            Console.Write("Wie teuer ist eine Hotelübernachtung > ");
            string input = Console.ReadLine();



            //Console.ReadKey
            Console.Clear(); //Komplette Console wird gelöscht.  We der CLS Befahl in DOS 
            //cw + [Tab] + [tab]
            Console.WriteLine("--- Hauptmenü --- ");
            Console.WriteLine("(1) Menüpunkt 1");
            Console.WriteLine("(2) Menüpunkt 2");
            Console.WriteLine("(3) Menüpunkt 3");

            ConsoleKeyInfo inputKey = Console.ReadKey(); //Readkey nimmt das erste eingegebene Charakter und erzeugt keinen Zeilenumbruch

            Console.WriteLine($"\nDeine Menüeingabe ist: {inputKey.KeyChar}" );


            if (inputKey.Key == ConsoleKey.NumPad1 || inputKey.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Menüpunkt 1 wurde ausgewählt. ");
            }

        }
    }
}
