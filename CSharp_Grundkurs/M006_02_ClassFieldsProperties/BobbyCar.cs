using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_02_ClassFieldsProperties
{
    public class BobbyCar
    {
        private int _baujahr;

        //Auto-Property
        public string Marke { get; set; }
        public string Model { get; set; } //Es wird beim kompilieren eine Variable angelegt -> der Programmierer muss sich hier um nichts weiteres kümmern
    
        public bool MotorStatus { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }
        public int MaximaleGeschwindigkeit { get; set; }

        public int Baujahr 
        {
            get => _baujahr;
            
            set
            {
                if (value < 1885)
                {
                    _baujahr = 1885;
                }
                else
                    _baujahr = value;

            }
        }



        public BobbyCar(string marke, string model, int maxGeschw)
        {
            Marke = marke;
            Model = model;
            MotorStatus = false;
            MaximaleGeschwindigkeit = maxGeschw;
        }

        public BobbyCar(string marke, string model, int maxGeschw, int baujahr)
           : this(marke, model, maxGeschw)
        {

            Baujahr = baujahr;
        }
    }
}
