using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_02_ClassFieldsProperties
{
    public class ElectroCar
    {
        private bool _motorOn;
        private string _marke;
        private string _model;
        private int _baujahr;
        private int _reichweite = 100; //Default

        private int _maximaleGeschwindigkeit;
        private int _aktuelleGeschwindigkeit;


        //Konstruktoren regeln das gesamte befüllen von Variablen (Member-Variablen oder Fields) 
        
        //Konstruktoren ohne Parameter nennt man Default Konstruktoren
        public ElectroCar()
        {
            //Das auto soll am Anfang stehen
            MotorOn = false;
            AktuelleGeschwindigkeit = 0;
        }

        public ElectroCar( string marke, string model, int baujahr, int reichweite, int maximaleGeschw, bool motorOn)
            : this()
        {
            Marke = marke;
            Model = model;
            Baujahr = baujahr;
            Reichweite = reichweite; //set -> pricvate set = Ich setze INNERHALB der Klasse die Property Reichweite.
            MaximaleGeschwindigkeit = maximaleGeschw;
        }

        




        //Ausgeschriebene Property
        public string Marke
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();

                _marke = value;
            }

            get
            {
                return _marke;
            }
        }

        public string Model
        {
            get => _model;
            //ist eine kurzschreibweise von:

            //  get
            //  {
            //      return _model;
            //  }

            set => _model = value;  
            //ist eine kurzschreibweise von:
            //set
            //{
            //    _model = value,
            //}
        }

        // Properties können auch nur ein Get-Part haben 
        public int Reichweite
        {
            //Hier muss die REichweite irgendwie gesetzt werden:
            
            //Variante1: Default Wert an der Variablen 
            //per Konstruktor
            private set
            {
                _reichweite = value;
            }



            get
            {
                return _reichweite;
            }
        }


        public int Baujahr
        {
            get => _baujahr;

            private set
            {
                _baujahr = value;
            }
            
        }

        public int AktuelleGeschwindigkeit
        {
            get => _aktuelleGeschwindigkeit;

            set => _aktuelleGeschwindigkeit = value;
            
        }


        public int MaximaleGeschwindigkeit
        {
            get => _maximaleGeschwindigkeit;
            set => _maximaleGeschwindigkeit = value;
        }


        #region Allgemeine Methoden

        public void Beschleudigt(int offsetKmH)
        {
            if ((AktuelleGeschwindigkeit + offsetKmH) > MaximaleGeschwindigkeit)
                AktuelleGeschwindigkeit = MaximaleGeschwindigkeit;


            AktuelleGeschwindigkeit = MaximaleGeschwindigkeit;
        }

        public void Bremsen()
        { 
            //Einmal Bremsenaufruf = -5 kmh

            if ((AktuelleGeschwindigkeit - 5) < 0)
            {
                AktuelleGeschwindigkeit = 0;
            }
                
        }

        public void MotorAusschalten()
        {
            AktuelleGeschwindigkeit = 0;
            MotorOn = false;
        }
        public bool MotorOn 
        { 
            get => _motorOn; 
            set => _motorOn = value; 
        }

        public void FillPetrol(int liter)
        {

        }
        #endregion
    }
}
