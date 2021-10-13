﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_03_UsingSample
{
    public class MyFileStream
    {
        public string FilePath { get; set; }

        public MyFileStream()
        {

        }

        public MyFileStream(string file)
        {
            this.FilePath = file;
        }

        public void ParseFile()
        {
            Debug.WriteLine("Wir parsen eine Datei");
        }
    }
}
