using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_01_Vererbung
{
    #region Böse Code
    public class BadGiroKonto
    {
        public decimal Kontostand { get; set; }
        public decimal Dispo { get; set; }

        public void Abheben(decimal geldbetrag)
        {
            Kontostand -= geldbetrag;
        }

        public void Einzahlen(decimal geldbetrag)
        {
            Kontostand += geldbetrag;
        }
    }

    public class BadSparbuch
    {
        public decimal Kontostand { get; set; }
        public decimal Zinssatz { get; set; }
        public void Abheben(decimal geldbetrag)
        {
            Kontostand -= geldbetrag;
        }

        public void Einzahlen(decimal geldbetrag)
        {
            Kontostand += geldbetrag;
        }
    }
    #endregion


    #region Vererbungen bei Kontosystemen

    public class Account
    {
        public decimal Kontostand { get; set; }
        
        public Account(decimal kontostand)
        {
            this.Kontostand = kontostand;
        }
        public virtual void Abheben(decimal geldbetrag)
        {
            Kontostand -= geldbetrag;
        }

        public virtual void Einzahlen(decimal geldbetrag)
        {
            Kontostand += geldbetrag;
        }
    }


    public class Girokonto : Account
    {
        public decimal Dispo { get; set; }


        public Girokonto(decimal kontostand, decimal dispo)
            :base(kontostand)
        {
            this.Dispo = dispo;
        }


        public override void Abheben(decimal geldbetrag)
        {
            if ((Kontostand - geldbetrag) < Dispo)
                throw new GiroAccountDispotException($"Der abzugehebne Betrag: {geldbetrag} übersteigt die Dispü-Linie");

            base.Abheben(geldbetrag);
        }
        //Es ist möglich hier eine Methode zu platzieren, die die Base-Methode -> Abheben ersetzt
    }


    public class Sparbuch : Account
    {
        public decimal Zinssatz { get; set; }

        public Sparbuch(decimal kontostand, decimal zinssatz)
           : base(kontostand)
        {
            this.Zinssatz = zinssatz;
        }

        public override void Abheben(decimal geldbetrag)
        {
            if ((Kontostand - geldbetrag) < 0)
                throw new SparbuchException("Sparbuch kann keinen negativen Betrag beinhalten");
             
            base.Abheben(geldbetrag);
        }
    }

    //Hier weden allgemeine IT-Fehler dargestellt
    public class BankAccountException : Exception
    {
        public BankAccountException(string message)
            :base(message)
        {

        }
    }

    //Hier wird eine Exception erstellt, die nur dann verwendet wird, wenn ich mehr als mein Dispo angibt, überziehen möchte. 
    public class GiroAccountDispotException : BankAccountException
    {
        public GiroAccountDispotException(string message)
            :base(message)
        {

        }
    }

    public class SparbuchException : BankAccountException
    {
        public SparbuchException(string message)
            :base(message)
        {

        }
    }
    #endregion

}
