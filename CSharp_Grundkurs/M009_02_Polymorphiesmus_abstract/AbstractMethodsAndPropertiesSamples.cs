using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_02_Polymorphiesmus_abstract
{
    public abstract class BaseClass
    {
        public abstract void AbstractMethode();


        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public virtual int Z { get; set; }

        public virtual string Display()
        {
            return $"Hallo von BaseClass Implementierung";
        }
    }

    public class DerivedClass : BaseClass
    {
        private int _y;
        public override int X { get; set; }
        
        public override int Y 
        { 
            get
            {
                return _y;
            }

            set
            {
                if (value < 0)
                    _y = 0;
                else
                    _y = value;
            }
        }

        public override void AbstractMethode()
        {
            Console.WriteLine("Hallo von DerivedClass.AbstractMethode()");
        }
    }

    public class DerivedClass2WithVirtualMethods : BaseClass
    {
        //X und Z müssen implementiert werden
        public override int X { get; set; }
        public override int Y { get; set; }

        //Z kann implementiert werden
        public override int Z { get; set; }

        public override void AbstractMethode()
        {
            Console.WriteLine("Hallo von DerivedClass2WithVirtualMethods.AbstractMethode()");
        }

        public override string Display()
        {
            return $"Class> DerivedClass2WithVirtualMethods with the values X:{X} Y:{Y} Z:{Z}";
        }


    }
}
