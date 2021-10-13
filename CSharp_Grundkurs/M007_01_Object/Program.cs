using System;

namespace M007_01_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Bein linkesBein = new Bein(80);
            Bein rechtsBein = new Bein(79);
            Person person1 = new Person("Donald", "Duck", DateTime.Now, "white", linkesBein, rechtsBein);


            int left = 80;
            int right = 79;
            person1 = new Person("Dagobert", "Duck", DateTime.Now, "yellow", left, right);

        }
    }
}
