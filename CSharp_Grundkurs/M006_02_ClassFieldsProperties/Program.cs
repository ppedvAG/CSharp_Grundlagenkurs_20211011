using System;

namespace M006_02_ClassFieldsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Oldtimer oldtimer = new Oldtimer();
            oldtimer.SetMarke("Benz");
            string markenname = oldtimer.GetMarke();

            oldtimer.Beschleudigt();
            oldtimer.Bremsen();
            oldtimer.FillPetrol(10);

            ElectroCar electroCar = new ElectroCar();
            electroCar.
        }
    }
}
