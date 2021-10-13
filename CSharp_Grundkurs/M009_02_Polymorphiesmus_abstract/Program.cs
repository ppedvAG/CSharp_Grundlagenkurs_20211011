using System;
using System.Collections.Generic;

namespace M009_02_Polymorphiesmus_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.GetArea();

            Sqaure sqaure = new Sqaure(4);
            sqaure.GetArea();


            List<Shape> geoCollection = new List<Shape>();
            geoCollection.Add(circle);
            geoCollection.Add(sqaure);

            foreach (Shape current in geoCollection)
                Console.WriteLine($"Die Klasse {current.ToString()} ruft die Methode: GetArea auf mit folgendem Ergebnis {current.GetArea()}"); 
        }
    }
}
