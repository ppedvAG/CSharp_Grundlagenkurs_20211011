using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M010_02_OOP_AccessModifier_Lib
{
    public class Fahrzeug
    {
        public int publicVariable; //Überall
        private string privateVariable; //nur innerhalb der eigenen Klasse 

        //Wenn es um Vererbung geht (protected)
        protected string protectedString; //Wird nur innerhalb der eignen Klasse + in weitere abgeleitete Klassen
        private protected string privateProtectedString; ///nur innerhalb der eigenen Klasse  ODER innerhalb einer abgeleiteten Klasse in der aktuellen Assembly


        internal string internalString; //innerhalb der eigenen Assembly (Dll - / Exe-Project  )
        protected internal string protectedInternalString; //innerhalb der eigenen Assembly ODER oder abgeleitet Klasse in anderer Assembly

    }

    public class PKW : Fahrzeug
    {
        public void WhatIsUseable()
        {
            this.publicVariable = 123;
            this.internalString = "ich bin internal";
            this.protectedString = "ich bin protected";

            this.protectedInternalString = "ich bin protected internal string";
            this.privateProtectedString = "ich bin private Protected String";
        }

    }

    
    
    
    
    
    public class Haribo
    {
        public Fahrzeug Fahrzeug { get; set; }

        public void TuWas()
        {
            Fahrzeug.publicVariable = 123;
            Fahrzeug.protectedInternalString = "protectedInternalString";
            Fahrzeug.internalString = "internalString";


        }
    }
}
