using System;
using System.Collections.Generic;

namespace WiederholungTag2_TheClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(/*Konstruktoraufruf*/); //Warum kann ich hier einen Konstruktor verwenden, obwohl wir keinen programmiert haben



            //Kann man ohne Konstrukor eine Klasse/Objet befüllen
            Employee employee2 = new Employee()
            {
                //Bei dieser Initialisierung verwende ich die Properties und kein Konsturktor 
                Id = 1,
                Firstname = "Harry",
                Lastname = "Weinfurt",
                Birthday = new DateTime(1971, 5, 10),
                Salary = 5000
            };


            //Was macht ein Konstruktor? Befüllen Objektes mit Daten + befüllung können wir steuern. 

            //Deklaration 
            Employee employee3 = null;
            //Instanziierung
            employee3 = new Employee(123, "Otto", "Walkes", DateTime.Now, 5000);


            Employee newEmployee = null;
            List<Employee> employeeList = new List<Employee>();
            for(int i = 0; i < 5; i++)
            {
                //new Empoloyee bedeutet -> reserviere mir einen eigenen Speicherplatz
                newEmployee = new Employee(i, "Otto", "Walkes", DateTime.Now, 5000);
                employeeList.Add(newEmployee); //Wir übergeben die Referenz (Speicheradresse) an die Liste

                newEmployee.Salary *= 2;
            }

            employeeList.Clear();

            #region Anti Variante -> befüllen von Listen (Referenztypen + Instanziierung)
            //Achtung das ist ein gemeiner Fehler
            Employee newEmployee2 = new Employee(123, "Otto", "Walkes", DateTime.Now, 5000);
            for (int i = 0; i < 5; i++)
            {
                employeeList.Add(newEmployee2); //Referenz des Speicherplatzes wird übergeben

                newEmployee2.Id = i;
                newEmployee2.Firstname = "Max";
                newEmployee2.Lastname = "Moritz";
                newEmployee2.Birthday = DateTime.Now;
                newEmployee2.Salary = 12400;
            }
            #endregion
        }
    }
}
