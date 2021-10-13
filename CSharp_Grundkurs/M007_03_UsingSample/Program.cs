using System;
using System.IO;

namespace M007_03_UsingSample
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello World!");

            MyFileStream myFileStream;

            try
            {

                //Schreibe Code, in dem ein Fehler passsieren kann
                myFileStream = new MyFileStream("abc.txt");

                myFileStream.ParseFile(); //<-Hier könnte ja ein Fehler entstehen. 
            }
            catch (IOException ioexception)
            {
                //Wir loggen hier den Fehler, wenn eine IOException
            }
            catch (Exception ex)
            {
                //Wir loggen hier den Fehler, wenn eine IOException
            }
            finally
            {
                //Finally wird immer ausgefürt.

                //Bei Erfolg

                //Oder wenn eine Exception passiert. 

                //MyFileStream bauen wir ab, damit die Datei wieder vom OS freigegeben wird
                myFileStream = null;
            }

            //Wenn wir using verwenden, benötigen wir in der jeweiligen Klasse das Interface IDisposable
            using (MyFileStream fileStream = new MyFileStream("abc.txt"))
            {

            };//Dispose + Objekt wird abgebaut


            using FileStream f = new FileStream(@"C:\users\jaredpar\using.md", FileMode.CreateNew);


        }//Dispose + Objekt wird abgebaut
    }

    
}
