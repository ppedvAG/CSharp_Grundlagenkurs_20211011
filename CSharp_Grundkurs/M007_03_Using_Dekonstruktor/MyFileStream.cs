using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_03_Using_Dekonstruktor
{
    public class MyFileStreamABC
    {
        public string FilePath {get;set }

        public MyFileStream()
        {
            FilePath = string.Empty;
        }

        public MyFileStream(string filePath)
        {
            FilePath = filePath
        }

        public void ParseFile()
        {
            //Wir öffnen eine Datei -> FilePath
        }
    }
}
