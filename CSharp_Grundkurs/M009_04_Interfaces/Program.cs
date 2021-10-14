using System;

namespace M009_04_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public interface IFSK16
    {
        public bool CheckAge(int alterDesTeilnehmers);
    }

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

    public class SchnellsteAchterbahnDerWelt : Jahrmarktstand
    {

    }

    public class Wildwasserbahn : Jahrmarktstand
    {

    }

    public class PaintballArea : Jahrmarktstand
    {

    }
}
