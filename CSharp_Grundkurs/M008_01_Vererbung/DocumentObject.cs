using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_01_Vererbung
{
    public class DocumentObject
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public string AbsoluterFilePath { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }


        public virtual void PrintDocument() //Methode zum Drucken des Documents
        {
            Console.WriteLine("DocumentObject.PrintDocument -> Einfaches Document wird gedruckt");
        }

        public void RockMeAmadeus()
        {

        }
    }

    public class PDF : DocumentObject
    {
        public int CompressionsRate { get; set; }
        public bool WithWaterMark { get; set; }

        public override void PrintDocument()
        {
            //base.PrintDocument();

            Console.WriteLine("PDF wird gedruckt");
        }
    }


    public class CSVDocument : DocumentObject
    {
        public char Trenner { get; set; } = ';';


        public override void PrintDocument()
        {
            base.PrintDocument();
            Console.WriteLine("CSV-Format liegt jetzt ausgedruckt vor");
        }
    }
}
