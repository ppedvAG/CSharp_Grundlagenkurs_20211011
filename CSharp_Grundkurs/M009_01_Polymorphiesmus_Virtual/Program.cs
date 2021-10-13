using System;

namespace M009_01_Polymorphiesmus_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Virtual - Properties
            //Mit override Property Name
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.Name = "Einstein";

            MySecondDerivedClass mySecondDerivedClass = new MySecondDerivedClass();
            mySecondDerivedClass.Name = "Zweistein";
            #endregion

            Motorrad motorrad1 = new Motorrad();
            motorrad1.PS = 123;

            Motorrad motorrad2 = new Motorrad();
            motorrad2.PS = 123;
            
            //Vergleiche von Referencetypen 
            if (motorrad1.Equals(motorrad2))
            {
                Console.WriteLine("sind gleich");
            }
            else
                Console.WriteLine("sind ungleich");


            if (motorrad1 == motorrad2)
            {
                Console.WriteLine("sind gleich");
            }
            else
                Console.WriteLine("sind ungleich");
        }
    }

    #region Virtual mit Properties
    public class MyBaseClass
    {
        // virtual auto-implemented property. Overrides can only
        // provide specialized behavior if they implement get and set accessors.
        public virtual string Name { get; set; }

        // ordinary virtual property with backing field
        private int num;
        public virtual int Number
        {
            get { return num; }
            set { num = value; }
        }
    }

    

    public class MyDerivedClass : MyBaseClass
    {
        private string name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "Unknown";
                }
            }
        }
    }


    public class MySecondDerivedClass : MyBaseClass
    {

    }
    #endregion
}
