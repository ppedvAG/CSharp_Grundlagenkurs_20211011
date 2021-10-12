using System;

namespace M004_02_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Einstiegs-Beispiel -> Enums sind die besseren Aufzählungsstrukturen gegenüber einem Array

            string[] anredeFormen = new string[] { "Herr", "Frau", "Others" };
            string temp = anredeFormen[0]; //Herr


            Anrede myAnrede = Anrede.Herr;
            if (myAnrede == Anrede.Herr)
            {

            }

            #endregion


            #region Einstiegsbeispiel 2

            //schlechte Alternative 
            string[] TagInDerWoche = new string[] { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            //TagInDerWoche[0] -> Montag 


            Wochentag wochentag = Wochentag.Mi;
            if (wochentag == Wochentag.Mi)
            {
            }
            #endregion

            #region Auswertung eines Enums mithilfe von switch
            string message = string.Empty;


            switch (wochentag)
            {
                case Wochentag.Mo:
                case Wochentag.Di:
                case Wochentag.Mi:
                case Wochentag.Do:
                case Wochentag.Fr:
                    message = "Leider ist noch kein Wochenende..";
                    break;
                default:
                    message = "Wuhu! Endlich Wochenende!";
                    break;
            }
            #endregion



            #region Enum <-> int -> z.b beim Abspeichern eines Enums Richtung DB
            //Deklaration eines Wochentages
            wochentag = Wochentag.Sa;

            //lese Integer-Wert aus selektierten Enum-Eintrag (Sa hat den Wert '6')
            int wochenIndex = (int)wochentag;

           
            //Mithilfe von Integerwerten kann man auch Wochentags-Einträge selektieren 
            Wochentag newWochentag = (Wochentag)4;

            if (newWochentag == Wochentag.Do)
            {
                Console.WriteLine("Donnerstag wurde ausgewählt.");
            }
            #endregion



            #region BitFelder //https://docs.microsoft.com/de-de/dotnet/api/system.enum.hasflag?view=net-5.0 ->google: enums with flags ODER enum bitflags
            Fruechte fruchtkorb = Fruechte.Orange | Fruechte.Banane | Fruechte.Birne; //Hintergrund -> 37 

            bool IsOrangeImFruchtkopr = fruchtkorb.HasFlag(Fruechte.Orange);

            
            Console.WriteLine("Welche Früchte sind im Fruchtkorb");

            Fruechte[] myFruitArray = (Fruechte[])Enum.GetValues(typeof(Fruechte));


            //Gehe das komplette Array durch und prüfe, ob jeder Eintrag eventuell auch im Früchtekorb enthalten ist
            foreach (Fruechte currentFruit in myFruitArray)
            {
                if (fruchtkorb.HasFlag(currentFruit) && currentFruit != Fruechte.Keines)
                    Console.WriteLine(currentFruit);
            }


            #endregion
        }
    }


    public enum Anrede { Herr, Frau, Others, Dr, Prof }
    public enum Wochentag { Mo = 1, Di, Mi, Do, Fr, Sa, So } //Wenn kein Index explizit angegeben wird, dann beginnt ales von 0 

    //Binärrechnung Dezimalwert 144 (16)  -> 1 0 0 1 0 0 0 0
    [Flags]
    enum Fruechte
    {
        Keines = 0x0,
        Orange = 1,
        Kirsche = 2,
        Banane = 4,
        Apfel = 8,
        Pflaume = 16,
        Birne = 32
    }

    [Flags]
    enum RenderType
    {
        None = 0x0,
        DataUri = 0x1,
        GZip = 0x2,
        ContentPage = 0x4,
        ViewPage = 0x8,
        HomePage = 0x10 // Next two values could be 0x20, 0x40
    }

    enum BoilingPoints { Celsius = 100, Fahrenheit = 212 };


}
