using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_01_Polymorphiesmus_Virtual
{

    //Sealed verhindert, dass von dieser Klasse geerbt werden kann. 
    public sealed class MySqlConnection
    {
        public string ConnectionString { get; set; }

        public void Open() { }
        public void Close() { }
    }

    
}
