using System;
using System.Collections.Generic;

namespace M009_04_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //unser Jahrmarktrungang

            List<Jahrmarktstand> jahrmarkt = new List<Jahrmarktstand>();

            AutoScooter autoScooter = new AutoScooter();
            jahrmarkt.Add(autoScooter);
            jahrmarkt.Add(new AutoScooter()); //Kurzschreibweise

            jahrmarkt.Add(new MirrorCabinet());
            jahrmarkt.Add(new HorrorCabinet());
            jahrmarkt.Add(new Karusell());
            jahrmarkt.Add(new SchnellsteAchterbahnDerWelt());

            foreach (Jahrmarktstand currentJahrmarktStand in jahrmarkt)
            {
                if (currentJahrmarktStand is IFSK16)
                {
                    IFSK16 fsk16 = (IFSK16)currentJahrmarktStand;

                    

                    if (fsk16.CheckAge(15))
                    {
                        Console.WriteLine("Darf mitfahren");
                    }
                    else
                    {
                        Console.WriteLine("Ist noch zu jung");
                    }
                }
            }


        }
    }


    public interface IFSK16
    {
        public bool CheckAge(int alterDesTeilnehmers);
    }

    //public interface IHaveToilets

    public class Jahrmarktstand
    {
        public string Name { get; set; }
        public int Miete { get; set; }
        public int FlaecheInQuatratmeter { get; set; }

        public DateTime GeoeffnetVon { get; set; }
        public DateTime GeoeffnetBis { get; set; }
    }

    public class AutoScooter : Jahrmarktstand
    {
        public int AnzahlDerAutos { get; set; }
    }

    public class MirrorCabinet : Jahrmarktstand
    {
        //
    }

    public class HorrorCabinet : Jahrmarktstand, IFSK16
    {
        public int DarstellerAnzahl { get; set; }

        public bool CheckAge(int alterDesTeilnehmers)
        {
            return alterDesTeilnehmers >= 16;
        }
    }

    public class Karusell : Jahrmarktstand
    {

    }

    public class SchnellsteAchterbahnDerWelt : Jahrmarktstand, IFSK16
    {
        public bool CheckAge(int alterDesTeilnehmers)
        {
            return alterDesTeilnehmers >= 16;
        }
    }

    public class Wildwasserbahn : Jahrmarktstand
    {

    }

    public class PaintballArea : Jahrmarktstand, IFSK16
    {
        public bool CheckAge(int alterDesTeilnehmers)
        {
            return alterDesTeilnehmers >= 16;
        }
    }
}
