using System;

namespace M012_Extention_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Beispiel 1
            Person p1 = new Person() { Name="Otto" };
            Person p2 = new Person() { Name = "Otto" };

            Employee em1 = new Employee("Max");
            Employee em2 = new Employee("Max");

            //== Operator im Vergleich
             
            if (p1 == p2) //Prüft die Referenzen 
                Console.WriteLine("Klasse Person 1 == Person 2");
            else 
                Console.WriteLine("Klasse Person 1 != Person 2");

            if (em1 == em2) //Prüft die Werte
                Console.WriteLine("Record Employee 1 == Employee 2");
            else
                Console.WriteLine("Record Employee 1 != Employee 2");


            //Equals -> Klasse Object -> virtual bool Equals(object obj) 
            
            //Selbes Ergebnisverhalten bei em1.Equals(em2) und p1.Equals(p2);
            if (p1.Equals(p2))
            {
                Console.WriteLine("p1.Equals(p2) -> gleich");
            }
            else
            {
                Console.WriteLine("p1.Equals(p2) -> ungleich");
            }

            if (em1.Equals(em2))
            {
                Console.WriteLine("em1.Equals(em2) -> gleich");
            }
            else
            {
                Console.WriteLine("em1.Equals(em2) -> ungleich");
            }


            #endregion

            #region ToString 

            Console.WriteLine("ToString() - Beispiel: ");
            Console.WriteLine($"Klassenausgabe mit ToString(): {p1.ToString()}");
            Console.WriteLine($"Recordausgabe mit ToString(): {em1.ToString()}");
            #endregion

            #region GetHashCode
            Console.WriteLine("GetHashCode() - Beispiel: ");
            Console.WriteLine($"Klassenausgabe mit GetHashCode(): {p1.GetHashCode()}");
            Console.WriteLine($"Recordausgabe mit GetHashCode(): {em1.GetHashCode()}");
            #endregion


            #region With - Sample
            Teachers teacher1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };


            //Variable teacher2 befindet sich in der kommenden Zeile im Konstruktor-Mode -> Init-Variablen dürfen gesetzt werden 
            Teachers teacher2 = teacher1 with { LastName = "Müller" };


            #endregion
        }

    }

    public class Person
    {
        public string Name { get; set; }
    }

    public record Employee(string Name);

    public record Teachers(string FirstName, string LastName)
    {
        //Firstname
        //Lastname
        public string[] PhoneNumbers { get; init; }
    }

    public record Animal (int Id, string Name); //Default wird jede Property auf get;init gesetzt
    public record Bird(int Id, string Name, string Farbe, bool KannSingen) : Animal(Id, Name);

    public record Movie
    {
        public string Title { get; set; } //set können wir auch verwenden, müssen aber das Record dann ausschreiben
    }
}
