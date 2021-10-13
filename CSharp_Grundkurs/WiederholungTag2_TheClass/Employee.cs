﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiederholungTag2_TheClass
{

    //Was wir hier sehen ist eine Klasse

    //Designzeit: Employee wird als Klasse, die wir erweitern etc. 
    //Zur Laufzeit: Wenn Klasse verwendet wird, spricht man Objekt und Objekt-Instaziierung 
    public class Employee
    {

        //Ein Default-Konstrukot wird der Klasse automatisch dazu gegeben

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        #region Konstuktor 
        //dieser Konstruktor regelt das Befüllen der Employee-Klasse mit folgenenden unten stehenden Variablen

        //Default-Konstruktor
        public Employee()
        {
            //Wollen den Defaultwert von int
            Id = default(int);
            Firstname = string.Empty;
            Lastname = string.Empty;
            Birthday = default(DateTime);
            Salary = default(int);
        }

        //Initialisierung Konstruktor
        public Employee(int id, string firstname, string lastname, DateTime birthday, int salary)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Salary = salary;
        }

        //Kopierkonstruktor
        public Employee(Employee otherEmployee)
        {
            Id = otherEmployee.Id;
            Firstname = otherEmployee.Firstname;
            Lastname = otherEmployee.Lastname;
            Birthday = otherEmployee.Birthday;
            Salary = otherEmployee.Salary;
        }
        #endregion
    }
}