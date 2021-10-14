using M010_02_OOP_AccessModifier_Lib;
using System;

namespace M010_03_AccessModifier_ConsolenApp
{
    class Program
    {
        static void Main(string[] args)
        {
             Fahrzeug Fahrzeug = new Fahrzeug();

             Fahrzeug.publicVariable = 123; //Internals sind hier nicht mehr verwendbar, weil die Klasse Fahrzeug hier sich nicht im eignen Assembly befindet 
        }


        public class Sportwagen : Fahrzeug
        {
            public void TuhWas()
            {
                this.publicVariable = 123; //Ich bin immer dabei
                this.protectedString = "protectedString";
                this.protectedInternalString = "ProtectedInternalString";
            }
        }


    }


}
