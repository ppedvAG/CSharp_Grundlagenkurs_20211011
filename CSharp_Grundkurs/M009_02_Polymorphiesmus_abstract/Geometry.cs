using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_02_Polymorphiesmus_abstract
{
    //Abstrakte Klassen sind keine Objekte mit denen ich eine Instanz herstellen kann
    
    //Eine abstrakte Klasse ist eine Vorlage, mit der ich bestimme,
    //welche Methoden/Prperties in den Vererbten Klassen ausimplementiert werden MÜSSEN!!!
    
    public abstract class Shape 
    {
        public abstract double GetArea();
    }

    public class Sqaure : Shape
    {
        int side;

        public Sqaure(int side)
        {
            this.side = side;
        }
        
        
        public override double GetArea()
        {
            return side * side;
        }
    }


    public class Circle : Shape
    {
        public override double GetArea()
        {
            //Achtung falsche Formel 
            return 1 + 2 * Math.PI;      
        }
    }
}
