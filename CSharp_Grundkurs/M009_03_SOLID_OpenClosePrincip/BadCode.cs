using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_03_SOLID_OpenClosePrincip.BadCode
{

    #region BadCode
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ReportGenerator
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            //Allgemeine Initialisierungen -< z.b Wo ist mein OutputPath oder Name des Reports 

            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
                
            }
            if (ReportType == "PDF")
            {
                //Libary für PDF Export
                //Fülllogik us
                // Report generation with employee data in PDF.
            }
            if (ReportType == "CSVReport")
            {

            }
        }
    }

    #endregion
}
