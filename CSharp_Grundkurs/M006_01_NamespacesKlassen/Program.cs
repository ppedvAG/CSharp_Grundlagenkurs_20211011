using System;
//using M006_01_NamespacesKlassen.ErstesNamespace; //Beispiel1 -> Hier fügen wir das Wörterbuch -> M006_01_NamespacesKlassen.ErstesNamespace ein
//using M006_01_NamespacesKlassen.ZweitesNamespace;


using First = M006_01_NamespacesKlassen.ErstesNamespace; //Alias
using Second = M006_01_NamespacesKlassen.ZweitesNamespace;

namespace M006_01_NamespacesKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasse kann man nicht ohne Namespaces mit angeben, weil wir das Problem bekommen, welche Klassen-Implementierung letztendlich gemeint ist.
            //MeineKlasse myclass = new MeineKlasse(); 

            //Absolute Klassenpfadangabe = Namespace + Klassennamen -> gibt die jeweilige Implementierungsort von MeineKlasse bekannt. 
            M006_01_NamespacesKlassen.ErstesNamespace.MeineKlasse meineKlasse1 = new ErstesNamespace.MeineKlasse();
            M006_01_NamespacesKlassen.ZweitesNamespace.MeineKlasse meineKlasse2 = new ZweitesNamespace.MeineKlasse();


            First.MeineKlasse meineKlasseA = new First.MeineKlasse();
            Second.MeineKlasse meineKlasseB = new Second.MeineKlasse();
        }
    }
}
