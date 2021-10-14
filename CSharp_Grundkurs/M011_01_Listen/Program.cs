using System;
using System.Collections;
using System.Collections.Generic;

namespace M011_01_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<T>
            List<string> namensListe = new List<string>();
            namensListe.Add("Max");
            namensListe.Add("Moritz");

            string neuerName = "Asterix";

            if (!namensListe.Contains(neuerName))
                namensListe.Add(neuerName);

            //Konventieren von Liste zu Array
            string[] myNameListArray = namensListe.ToArray();

            List<string> newListOfNames = new List<string>();

            //Hinzufügen eines Array in eine Liste
            newListOfNames.AddRange(myNameListArray);

            //Solid - > 4 Regel (Dependecy Inversion) 
            IList<string> myNameList = new List<string>(); //Wir verwenden die Liste wie gewohnt, allerdings verwenden wir nur die Methoden, die uns IList bietet


            #endregion


            #region Dictionary

            IDictionary<int, string> movieListe = new Dictionary<int, string>();
            movieListe.Add(1, "Star Wars");
            movieListe.Add(2, "Star Wars 2");
            movieListe.Add(3, "End of Days");

            //KeyValuePair<int, string> newEntry = new KeyValuePair<int, string>(4, "Herr der Ringe");
            //Ist dieser Key schon vorhanden -> Key müssen in einem Dictionary eindeutig sein.
            
            if (!movieListe.ContainsKey(4))
                movieListe.Add(4, "Kill Bill");

            KeyValuePair<int, string> neuerEintragViaKeyValuePair = new KeyValuePair<int, string>(5, "Scary Movie");
            movieListe.Add(neuerEintragViaKeyValuePair);

            //Durchlauf eines Dictionaries mithilfe einer foreach - Schleife + die Hilfstruktur KeyValuePair
            foreach (KeyValuePair<int, string> currentEntry in movieListe)
            {
                Console.WriteLine($"Id: {currentEntry.Key} Filmtitel: {currentEntry.Value}");
            }
            #endregion

            #region Nodes
            Node myRoot = new Node();
            myRoot.Parent = null;
            myRoot.Label = "Ich bin das Root-Object";

            myRoot.Childrens.Add(new Node() { Id = 2, Parent = myRoot });
            myRoot.Childrens.Add(new Node() { Id = 3, Parent = myRoot });
            myRoot.Childrens.Add(new Node() { Id = 4, Parent = myRoot });


            IDictionary<int, Node> myNodesDictionary = new Dictionary<int, Node>();
            myNodesDictionary.Add(myRoot.Id, myRoot);
            myNodesDictionary.Add(123, new NodeWithHashValue());
            foreach (Node currentChildNode in myRoot.Childrens)
            {
                myNodesDictionary.Add(currentChildNode.Id, currentChildNode);
            }

            #endregion

            #region Hastable

            Hashtable hashTable = new Hashtable();
            hashTable.Add("HAllo", "Wie gehts?");
            hashTable.Add(123, "Wie gehts?");
            hashTable.Add("Hallo", 123);

            hashTable.Add(new DateTime(), new ArrayList());
            #endregion
        }
    }

    public class Node
    {
        public int Id { get; set; }
        public string Label { get; set; }

        //...

        public Node Parent { get; set; } = null;

        public IList<Node> Childrens = new List<Node>();
    }

    public class NodeWithHashValue : Node
    {
        public int Pruefsumme { get; set; }
    }
}
