using System;
using System.Collections.Generic;

namespace M003_03_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klassische Zählschleife");


            //Eine Codezeile -> Console.WriteLine(i);
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i); // 0,1,2,3,4,5,6,7,8,9 (Length of 10 items) 

            //for-Schleife mit Body 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("-----------------");
            }

            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i}, ");
            }//10, 9, 8, 7, 6, 5, 4, 3, 2, 1,


            int myNumber = 123;

            //Was ist ein Array?
            //Es sind mehrere Variablen eines Types (int oder float oder string) in einer Struktur zusammengefasst


            //Array von 10 Variablen
            int[] zahlen = new int[10]; //Array hat jetzt eine feste größe von 10 Elementen

            //Variable 1 -> zahlen [index... 0 ... 9]
            zahlen[0] = 123;
            //Variable 2
            zahlen[1] = 456;
            //Variable 3 
            zahlen[2] = 789;

            zahlen[3] = 111;
            //Variable 2
            zahlen[4] = 222;
            //Variable 3 
            zahlen[5] = 333;
            zahlen[6] = 444;
            zahlen[7] = 555;
            //Variable 2
            zahlen[8] = 666;
            //Variable 3 
            zahlen[9] = 777;


            //kompaktere Schreibwweise

            int[] array2 = new int[] { 123, 456, 789, 111, 222, 333, 444, 555, 666, 777, }; //Array hat jetzt eine feste größe von 10 Elementen

            for (int i = 0; i <= array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }


            List<int> numListe = new List<int>(); //Liste verwendet intern eine Array-Liste (Anfangs mit einer Default-Größe von 4 - Felder) 
            numListe.Add(12);
            numListe.Add(44);
            numListe.Add(55);
            numListe.Add(123);
            numListe.Add(77);

            int abc = numListe[0]; //Liste hat auch einen Index

            int[] convertedArray = numListe.ToArray(); //Können in ein Array-Konventieren 

            List<int> newList = new List<int>();
            newList.AddRange(convertedArray);


            #region foreach
            //Geht jedes Element eines Array oder Liste durch
            foreach (int currentIntegerValue in zahlen)
            {

                //currentIntegerValue -> 123 / 456 / 789 / 111/ 222 / 333 ... 
                //Wenn ich hier ankomme, dann hat mein Array -> zahlen mindestens einen Eintrag 
                Console.Write(currentIntegerValue);

            } //Wenn zahlen leer ist oder eine List<int> leer ist, gibt es keinen Durchlauf
            Console.Write("\n");
            #endregion
        }
    }
}
