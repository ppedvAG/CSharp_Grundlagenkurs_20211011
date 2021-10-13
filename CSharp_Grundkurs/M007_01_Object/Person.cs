using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_01_Object
{
    public class Bein //Klassen sind Referenztypen
    {
        public double Länge { get; set; }
        public bool IsHealthy { get; set;}
        public bool HaveLegATattoo { get; set; }

        public Bein(int länge)
        {
            this.Länge = länge;
        }
    }

    public class Person
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public DateTime Geburtstag { get; set; }

        public string HaarFarbe { get; set; }

        public Bein LinkesBein { get; set; }
        public Bein RechtesBein { get; set; }


        public int LeftLegSize { get; set; }
        public int RightLegSize { get; set; }

        //shortcut 
        //ctor + tab + tab

        public Person(string vorname, string nachname, DateTime geburtstag, string haarfarbe, Bein linkesBein, Bein rechtsBein)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtstag = geburtstag;
            HaarFarbe = haarfarbe;

            LinkesBein = linkesBein; //Referenz wird übergeben, keine Kopie 
            RechtesBein = rechtsBein;
        }

        public Person(string vorname, string nachname, DateTime geburtstag, string haarfarbe, int leftLegSize, int rightLegSize)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtstag = geburtstag;
            HaarFarbe = haarfarbe;
            LeftLegSize = leftLegSize;
            RightLegSize = rightLegSize;
         
        }
    }
}
