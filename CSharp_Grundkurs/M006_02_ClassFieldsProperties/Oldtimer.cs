using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_02_ClassFieldsProperties
{
    public class Oldtimer
    {
        private string _marke; //Member-Variable (früher) / Fields(Felder) (heute) 

        public void SetMarke(string marke) //Set-Methode hilft mir dass ich valide Daten an die Member-Variabke _marke übermitteln kann
        {
            //Validerung
            if (string.IsNullOrEmpty(marke))
                throw new ArgumentException("Parameter marke wurde falsch ausgefüllt");

            _marke = marke;
        }

        public string GetMarke()
        {
            //Valdierung immer in die Set-Methode
            //if (string.IsNullOrEmpty(_marke))
            //    return "Benz";

            return _marke;
        }


        #region Allgemeine Methoden

        public void Beschleudigt()
        {

        }

        public void Bremsen()
        {

        }

        public void FillPetrol(int liter)
        {
            
        }
        #endregion
    }
}
