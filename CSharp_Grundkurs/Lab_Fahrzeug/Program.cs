using System;
using System.Collections.Generic;

namespace Lab_Fahrzeug
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fahrzeug fahrzeug = new Fahrzeug();

            //double kmh = Fahrzeug.MphToKmh(100);
            //double mph = Fahrzeug.KmhTOMph(100);


            Flugzeug flugzeug = null;
            List<Fahrzeug> myFlughafenHangar = new List<Fahrzeug>();
            

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    //Console.WriteLine($"Erstelle Flugzeug Nr. {i}");
                    flugzeug = new Flugzeug("Airbus", 2000000, 500, 10, 12000);

                    Console.WriteLine(Flugzeug.ZeigeAnzahlErstellterFahrzeuge());
                    myFlughafenHangar.Add(flugzeug);
                }
            }
            catch (FahrzeugException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
