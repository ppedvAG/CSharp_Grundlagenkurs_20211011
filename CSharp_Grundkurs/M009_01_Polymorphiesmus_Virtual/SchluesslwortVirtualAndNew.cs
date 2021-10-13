using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_01_Polymorphiesmus_Virtual
{
    public class Fahrzeug
    {
        public int PS { get; set; }
        public virtual string WasBinIch()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Auto : Fahrzeug
    {
        public new string WasBinIch()
        {
            return "Ich bin ein Auto";
        }
    }

    public class ElectroCar : Auto
    {
        //public new string Auto.WasBinIch() beendet das anbieten einer virtual Variable. 
        //Wenn 
        public string WasBinIch(string str)
        {
            return "Ich bin ein Elektro-Auto";
        }
    }


    public class Motorrad : Fahrzeug
    {
        
        public override string WasBinIch()
        {
            return "Ich bin ein Motorrad";
        }

        public override string ToString()
        {
            return $"Ich bin ein tolles Motorrad und habe {PS} PS.";
        }


        #region Vergleichn von ReferenceTypen auf dessen Werte
        public override bool Equals(object obj)
        {
            Motorrad motorradToCheck = (Motorrad)obj;

            if (this.PS != motorradToCheck.PS)
                return false;

            return true;
        }

        public static bool operator == (Motorrad left, Motorrad right)
        {
            if (left.PS != right.PS)
                return false;

            return true; 
        }

        public static bool operator !=(Motorrad left, Motorrad right)
        {
            if (left.PS == right.PS)
                return false;

            return true;
        }
        #endregion
    }
    public class ZweiSitzerMotorad : Motorrad
    {
        public override string WasBinIch()
        {
            return "Ich bin ein ZweiSitzerMotorad";
        }

        
    }


}
