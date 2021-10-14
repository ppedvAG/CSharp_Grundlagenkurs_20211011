using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M010_02_OOP_AccessModifier_Lib.WeitererNamespace
{
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
}
