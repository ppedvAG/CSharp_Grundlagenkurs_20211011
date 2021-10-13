using System;

namespace M006_02_ClassFieldsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anti-Beispiel

            //Die Klasse DummyCar kann nicht die Zuweisungen beinflussen (validieren) 
            //Methoden haben keine Genauigkeit, weil wir von Aussen alle Variablen direkt verändern können, 

            DummyCar dummyCar = new DummyCar();
            dummyCar.Marke = "Benz";
            dummyCar.Model = "Silberpfeil";
            dummyCar.Motor = true;

            
            dummyCar.Beschleunige();
            #endregion



            #region Set/Get-Methoden (älterer Stil) 

            Oldtimer oldtimer = new Oldtimer();
            
            //Set-Methoden regeln die Initialisierung von Marke
            oldtimer.SetMarke("Benz");

            //Get-Methode regelt das lesen von der Variable Marke 
            string markenname = oldtimer.GetMarke();


            //Allgemeine Klassen-Methoden
            oldtimer.Beschleudigt();
            oldtimer.Bremsen();
            oldtimer.FillPetrol(10);
            #endregion

            #region Properties
            ElectroCar electroCarBlank = new ElectroCar(); //DEfaultKonstruktor wird aufgerufen 

            //ElectroCar electroCar = new ElectroCar(false, "Benz", "Silberpfeil", 1932, 80, 120);
            #endregion


            #region Auto Properties
            BobbyCar myFirtBobyCar = new BobbyCar();


            BobbyCar bobbyCar = new BobbyCar("Bugatti", "V8", 320, 2020);

            #endregion
        }
    }
}
