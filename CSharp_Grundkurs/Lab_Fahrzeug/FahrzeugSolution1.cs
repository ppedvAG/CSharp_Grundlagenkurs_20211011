using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Fahrzeug
{

    //Mit Berrücksichtigung der SOLID - Regel -> OpenClose()

    public class Fahrzeug
    {
        #region Properties
        public string Name { get; set; }
        public decimal Preis { get; set; }

        public int MaximalGeschwindigkeit { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }

        public bool MotorActive { get; set; }
        #endregion

        #region Static Properties -> Statische Variablen sind zentral
        public static int AnzahlErstellterFahrzeuge { get; private set; } = 0; //Metainfo - Wieivele Fahrezuge (Flugzeuge,Schiffe, PKWs) erstellt wurden 
        public static int MaxAnzahlErstellterFahrzeuge { get; private set; } = 50;

        public static string ZeigeAnzahlErstellterFahrzeuge()
        {
             
            return $"Es wurden {AnzahlErstellterFahrzeuge} erstellt";
        }
        #endregion

        public Fahrzeug ()
        {
            if (AnzahlErstellterFahrzeuge < MaxAnzahlErstellterFahrzeuge)
                AnzahlErstellterFahrzeuge++;
            else
                throw new FahrzeugException("Das Limit der erstellten Fahrzeuge ist erreicht");



            MotorActive = false;
            AktuelleGeschwindigkeit = 0;
        }

        public Fahrzeug (string name, decimal preis, int maximaleGeschwindigkeit)
            : this()
        {
            Name = name;
            Preis = preis;
            MaximalGeschwindigkeit = maximaleGeschwindigkeit;
        }

        public void Beschleunigung (int offsetSpeed)
        {
            if ((AktuelleGeschwindigkeit + offsetSpeed) > MaximalGeschwindigkeit)
                AktuelleGeschwindigkeit = MaximalGeschwindigkeit;

            AktuelleGeschwindigkeit += offsetSpeed;
        }

        public virtual void StarteMotor()
        {
            MotorActive = true;
        }

        public virtual void StoppeMotor()
        {
            AktuelleGeschwindigkeit = 0;
            MotorActive = false;
        }


        #region Hilfsmethoden -> Konventierungsmethoden / Berechnungsmethoden
        public static double KmhTOMph(double kmh)
        {
            return 0.6214 * kmh;
        }

        public static double MphToKmh(double mph)
        {
            return mph * 1.60934;
        }
        #endregion
    }


    public class FahrzeugException : Exception
    {
        public FahrzeugException(string msg)
            :base(msg)
        {

        }
    }
    public enum SpritTyp { Diesel, Super, Bleifrei }
    #region Plain
    public class Flugzeug : Fahrzeug
    {
        public double Spannweite { get; set; }
        public int MaxFlughoeheInMeter { get; set; }
        public int AktFlughoeheInMeter { get; set; }


        public Flugzeug(string name, decimal preis, int maximaleGeschwindigkeit, double spannweite, int maxFlueghoehe)
            :base(name, preis, maximaleGeschwindigkeit)
        {
            Spannweite = spannweite;
            MaxFlughoeheInMeter = maxFlueghoehe;
            AktFlughoeheInMeter = 0;
        }

        public override void StarteMotor()
        {
            base.StarteMotor();
        }

        public override void StoppeMotor()
        {
            base.StoppeMotor();
            AktFlughoeheInMeter = 0;
        }
    }
    #endregion

    public enum AntriebsTechnology { Electro, Benziner }
    
    
    //public class Car : Fahrzeug
    //{
    //    public AntriebsTechnology AntriebsTechnology { get; set; }


    //    public override void StarteMotor()
    //    {
    //        if (AntriebsTechnology == AntriebsTechnology.Electro)
    //        {
    //            //Ist Batterie noch aufgeladen
    //            //50 Zeilen
    //        }
    //        else if ( AntriebsTechnology == AntriebsTechnology.Benziner)
    //        {
    //            //Ist Bezin verfügbar 
    //            //50 Zeilen
    //        }
    //    }
    //}
    #region PKW
    
    public abstract class PKWBase : Fahrzeug
    {
        
        public PKWBase(string name, decimal preis, int maximaleGeschwindigkeit)
            :base (name, preis, maximaleGeschwindigkeit)
        {

        }
    }

    public class ElectroPKW : PKWBase
    {
        public int ReichweiteInKM { get; set; }
        public int MAH { get; set; }

        public int Akkuzustand { get; set; }

        public ElectroPKW (string name, decimal preis, int maximaleGeschwindigkeit, int reichweiteInKM, int mah)
            :base(name, preis, maximaleGeschwindigkeit)
        {
            ReichweiteInKM = reichweiteInKM;
            MAH = mah;
        }

        public override void StarteMotor()
        {
            //Setzten Motor auf Aktiv 
            if (Akkuzustand > 0)
                base.StarteMotor();
        }
    }

    public class VerbrennerPKW : PKWBase
    {
        public int TankVolumen { get; set; }
        public int Reichweite { get; set; }

        public SpritTyp Sprit { get; set; }
        

        public VerbrennerPKW(string name, decimal preis, int maximaleGeschwindigkeit, int tankVolumen, int reichweite, SpritTyp spritTyp)
            :base(name, preis, maximaleGeschwindigkeit)
        {
            Reichweite = reichweite;
            TankVolumen = tankVolumen;
            Sprit = spritTyp;
        }


    }
    #endregion

    #region Ship
    public abstract class ShipBase : Fahrzeug
    {
        public double Tiefgang { get; set; }

        public ShipBase(string name, decimal preis, int maximaleGeschwindigkeit, double tiefgang)
            :base(name, preis, maximaleGeschwindigkeit)
        {
            Tiefgang = tiefgang;
        }
    }

    public class Segelschiff  : ShipBase
    {
        public int MastAnzahl { get; set; }

        public Segelschiff(string name, decimal preis, int maximaleGeschwindigkeit, double tiefgang, int mastAnzahl)
            :base(name, preis, maximaleGeschwindigkeit, tiefgang)
        {
            MastAnzahl = mastAnzahl;
        }
    }

    public class MotorBoot : ShipBase
    {
        public int TankVolumen { get; set; }
        public int Reichweite { get; set; }
        public SpritTyp Sprit { get; set; }

        public MotorBoot(string name, decimal preis, int maximaleGeschwindigkeit, double tiefgang, int tankVolumen, int reichweite, SpritTyp spritTyp)
            :base(name, preis, maximaleGeschwindigkeit,tiefgang)
        {
            TankVolumen = tankVolumen;
            Reichweite = reichweite;
            Sprit = spritTyp;
        }
    }

    public class Yacht : MotorBoot
    {
        bool Pool { get; set; }

        public Yacht(string name, decimal preis, int maximaleGeschwindigkeit, double tiefgang, int tankVolumen, int reichweite, SpritTyp spritTyp, bool mitPool)
            :base(name, preis, maximaleGeschwindigkeit, tiefgang, tankVolumen, reichweite, spritTyp)
        {
            Pool = mitPool;
        }
    }

    #endregion
}
