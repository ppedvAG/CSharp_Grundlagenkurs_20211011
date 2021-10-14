using System;

namespace M009_03_SOLID_OpenClosePrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public abstract class ReportGeneratorBase
    {
        public abstract void Generate(Employee emp);
    }

    public class PDFGenerator : ReportGeneratorBase
    {
        //Hier kann man weitere Implementierung angehen für PDF - Optionen

        public override void Generate(Employee emp)
        {
            //Generiere eine PDF
        }
    }

    public class CrystalReportsGenerator : ReportGeneratorBase
    {
        public override void Generate(Employee emp)
        {
            //Genierer ein CR
        }
    }
}
