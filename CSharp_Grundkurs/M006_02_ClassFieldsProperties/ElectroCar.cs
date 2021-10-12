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
        private int _reichweite = 100;

        private int _maximaleGeschwindigkeit;
        private int _aktuelleGeschwindigkeit;

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
