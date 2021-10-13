using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_01_Vererbung
{
    public class Lebewesen
    {
        public int Alter { get;  set; }//Diese Property wird auch in der Klasse angeboten

        public Lebewesen()
        {
            Alter = 0; //Bei Geburt
        }

        public Lebewesen(int alter)
        {
            this.Alter = alter;
        } 

        public void Essen()
        {
            Console.WriteLine("Lebewesen isst");
        } //Diese Methode wird auch in der Klasse angeboten
    }

    public class Mensch : Lebewesen
    {
        public string Wohnort { get; set; }
        public bool HaveFahrlizenz { get; set; }

        public Mensch(int alter, string wohnort)
           : base(alter)
        {
            this.Wohnort = wohnort;
        }
        public Mensch(int alter, string wohnort, bool fahrlizenz)
            :base(alter)
        {
            this.Wohnort = wohnort;
            this.HaveFahrlizenz = fahrlizenz;
        }


        public void Sprechen()
        {
            Console.WriteLine("Mensch kann sprechen");
        }

        public void Schreiben()
        {
            Console.WriteLine("Mensch kann schreiben");
        }

        public void Lesen()
        {
            Console.WriteLine("Mensch kann lesen");
        }
    }

    public class Vogel : Lebewesen
    {
        public double Fluegelspannweite { get; set; }
        
        public void Fliegen()
        {

        }

        public void Zwitschern()
        {
        }

        public void LegeEinEi()
        {
        }
    }

}
