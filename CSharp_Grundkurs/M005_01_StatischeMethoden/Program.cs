using System;

namespace M005_01_StatischeMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            #region Überlagern von Methoden
            Display();
            Display(123, "Hallo liebe Teilnehmer");
            Display("Schönes Wetter in Berlin", 123);
            Display("Blogartikel: C# 10", "Artikel über die neuen C#-Features", "copyright PPEDV");
            #endregion

            #region Optionale Parameter

            //Strings Verbinden - Beispiel
            string[] myStrings = { "eins", "zwei", "drei" };

            StringVerbinden(myStrings, '-');
            StringVerbinden(myStrings);
            #endregion

            #region Parametertyp-Params
            //Wie war es in den Zeit vor Params
            int[] meinZahlenArray = { 1, 2, 3, 4 };
            int result = AddiereOld(meinZahlenArray);


            int[] numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 90 };


            result = Addiere(1, 2, 3, 4, 5, 6, 7, 8, 11, 22, 33, 44, 55, 66);
            result = Addiere(1, 2, 3, 4, 5);
            result = Addiere(meinZahlenArray);
            #endregion

            //Wertetypen: bool, short, byte, int, long, ....  decimal, double, float, string, struct(wobei String wird als Referenztyp klassifiert) 
            //Referenztypen: class, interface, 

            int theAge = 33;
            Altern(theAge);


            #region Ref
            theAge = 33;
            AlternWithRef(ref theAge);

            #endregion

            #region out
            AlternWithReferenzParameterOut(out theAge);
            int convertedNumber;
            
            if (int.TryParse("12345", out convertedNumber))
            {
                Console.WriteLine(convertedNumber); 
            }
            #endregion

            #region in

            #endregion

        }




        #region Überlagern von Methoden
        /// <summary>
        /// void - gibt nichts zurück
        /// </summary>
        public static void Display(/*Parameter*/)
        {
            Console.WriteLine("Hallo liebe Teilnehmer");
        }


        //Methoden Signatur beinhaltet -> Methoden-Namen + Parameterliste
        public static void Display(string message, int msgNumber)
        {
        }

        public static void Display(int msgNumber, string message)
        {
        }

        public static void Display(string headerText, string bodyText, string footerText)
        {
        }

        #endregion

        #region Optionale Parameter
        
        static string StringVerbinden(string[] strings, char trenner = '*')
        {
            string resultStrings = strings.Length > 0 ? strings[0] : throw new ArgumentException("StringVerbinden -> Paramter: string is null");
        
            for (int i=1; i < strings.Length; i++)
            {
                resultStrings += (trenner + strings[i]);
            }

            return resultStrings;
        }

        #endregion

        #region Parametertyp-Params
        public static int AddiereOld(int[] zahlen)
        {
            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
                summe += zahlen[i];

            return summe;
        }


        static int Addiere(params int[] zahlen)
        {
            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
                summe += zahlen[i];

            return summe;
        }


        static void Methode(string text, params string[] strArray)
        {
            Console.WriteLine(text);
            Console.WriteLine("------------");

            foreach(string currentString in strArray)
                Console.WriteLine(currentString);
        }
        #endregion


        #region Wertetyp / Referenztyp - Allgemeines Beispiel + Ref-Beispiel
        public static void Altern(int age)
        {
            age++;
        }
        public static void AlternWithRef(ref int age)
        {
            age++;
        }
        #endregion

        #region Referenzen mit Out Paramter
        public static void AlternWithReferenzParameterOut(out int age)
        {
            age = 99; //Out muss eine Zuweiseung erfahren.
        }
        #endregion


        #region Referenzen mit In-Parameter
        public static void AlternWithIn(in int age)
        {
            int newage = age + 1;


            Console.WriteLine(age);

            //Age ist nur readonly 
        }

        #endregion
    }
}
