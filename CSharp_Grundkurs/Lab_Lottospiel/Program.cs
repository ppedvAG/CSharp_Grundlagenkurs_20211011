using System;
using System.Linq;

namespace Lab_Lottospiel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zufallsgenerator
            Random generator = new Random();
            int[] benutzerZahlen = new int[3];
            int[] zufallsZahlen = new int[3];
            int treffer = 0;

            //Würfeln der Zahlen
            for (int i =0; i < zufallsZahlen.Length; i++)
            {
                int temp;

                do
                {
                    temp = generator.Next(1, 11);
                } while (zufallsZahlen.Contains(temp));
                zufallsZahlen[i] = temp;
            }

            ////Schleife zum Erfragen der Benutzerzahlen
            for (int i = 0; i < benutzerZahlen.Length; i++)
            {
                Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ");
                benutzerZahlen[i] = int.Parse(Console.ReadLine());
            }


            //Trefferermittlung 
            foreach (int zahl in zufallsZahlen)
            {
                //Ist die gezogene Lottozahl auf meinem Lottozettel
                if (benutzerZahlen.Contains(zahl))
                {
                    treffer++;
                }
            }


            Console.Write("Gewinnzahlen der heutigen Samstag-Lotterie: ");
            foreach (int currentNumber in zufallsZahlen)
                Console.Write($" {currentNumber} ");

            Console.WriteLine($"Treffer: {treffer}");

            //Benutzer gibt unterschiedliche Lottozahlen ein

                //lottozahlen.Contains()
                //Lottofee zieht drei unterschiedliche Lottozahlen


                //Wieviele Matches hat der Mitspieler 
        }
    }
}
