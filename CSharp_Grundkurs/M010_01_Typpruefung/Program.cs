using System;
using System.Collections.Generic;

namespace M010_01_Typpruefung
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Basis-Beispiel
            AbgeleiteteKlasse abgeleiteteKlasse = new AbgeleiteteKlasse();
            abgeleiteteKlasse.Id = 199;
            abgeleiteteKlasse.Description = "abc";

            //Was wird hier zurück gegeben? 
            Type abgeleiteteKlassenTyp = abgeleiteteKlasse.GetType(); //Hier haben wir eine Instanz

            Type abgeleiteteKlassenTyp2 = typeof(AbgeleiteteKlasse); //Typangabe 


            Console.WriteLine("##### Testen mit -> abgeleiteteKlasse.GetType() #####");
            if (abgeleiteteKlasse.GetType() == typeof(AbgeleiteteKlasse))
            {
                Console.WriteLine($"abgeleiteteKlasse.GetType() == typeof(AbgeleiteteKlasse) -> erkennt typeof(AbgeleiteteKlasse)");
            }

            if (abgeleiteteKlasse.GetType() == typeof(Basisklasse))
            {
                Console.WriteLine($"abgeleiteteKlasse.GetType() == typeof(Basisklasse) -> erkennt typeof(Basisklasse)");
            }

            if (abgeleiteteKlasse.GetType() == typeof(ICloneable))
            {
                Console.WriteLine($"abgeleiteteKlasse.GetType() == == typeof(ICloneable) -> erkennt typeof(ICloneable)");
            }



            Console.WriteLine("##### Testen mit 'is' Operator  #####");

            

            if (abgeleiteteKlasse is Basisklasse)
            {
                Console.WriteLine("Erkennt abgeleiteteKlasse als AbgeleiteteKlasse");
            }

            if (abgeleiteteKlasse is ICloneable myCloneInterface)
            {
                Console.WriteLine("Erkennt das Interface ICloneable");
            }


            if (abgeleiteteKlasse is AbgeleiteteKlasse instance)
            {
                Console.WriteLine("Erkennt abgeleiteteKlasse als AbgeleiteteKlasse");

                Console.WriteLine(instance.Id );
                Console.WriteLine(instance.Description); 
            }

            #endregion



            List<Shape> geometrieCollection = new List<Shape>();

            geometrieCollection.Add(new Rectangle() { x = 5, y = 6 });
            geometrieCollection.Add(new Circle(4));
            geometrieCollection.Add(new Sphere(7));
            geometrieCollection.Add(new Cylinder(5, 4));

            Rectangle rectangle1 = new Rectangle() { x = 5, y = 6, GehtDieserVariablenInhaltVerloren = 777 };
            rectangle1.WeitereWichtigeMethode();

            Shape rectangeWithShapeBasisType = rectangle1;
            //rectangeWithShapeBasisType.WeitereWichtigeMethode(); //Hilfe wo ist meine MEthode hin? 
            //rectangeWithShapeBasisType.Area();
            //rectangeWithShapeBasisType.x;
            //rectangeWithShapeBasisType.y;


            Rectangle rectangle2 = (Rectangle)rectangeWithShapeBasisType;
            rectangle2.WeitereWichtigeMethode();
            Console.WriteLine(rectangle2.GehtDieserVariablenInhaltVerloren);

            //rectangle1.Area();
            //rectangle1.x;
            //rectangle1.y;
            //rectangle1.WeitereWichtigeMethode
            //Shape rectangle2 = new Rectangle();

            foreach (Shape currentGeoForm in geometrieCollection)
            {
                Console.WriteLine(currentGeoForm.Area());
                

                if (currentGeoForm is Rectangle rect)
                {
                    rect.WeitereWichtigeMethode();
                }
            }
        }


    }

    public class Basisklasse
    {
    }

    public class AbgeleiteteKlasse : Basisklasse, ICloneable
    {
        public int Id { get; set; }
        public string Description { get; set; }
        
        public object Clone() //Man kann eine Kopie von sich selber ausgeben
        {
            AbgeleiteteKlasse cloneObject = new AbgeleiteteKlasse();
            cloneObject.Id = this.Id;
            cloneObject.Description = this.Description;
            return cloneObject;
        }
    }

    #region Geometrie
    public class Shape
    {
        public const double PI = Math.PI;
        public double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }

        public virtual void HelpMe()
        {
            Console.WriteLine("Hier wird eine Dokumentation zur jeweilige Geoform gezeigt.");
        }
    }



    public class Rectangle : Shape
    {
        //Hie müssen wir nichts überschreiben (x*y) reicht komplett aus für eine Rechtseckberechnung

        public int GehtDieserVariablenInhaltVerloren { get; set;  } //Wir casten in Shape und wieder zurück und hoffe, dass hier der initialiserte Wert noch vorhanden ist.

        public void WeitereWichtigeMethode()
        {

        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * x * x;
        }
    }

    class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
    #endregion
}
