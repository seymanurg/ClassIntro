using System;

namespace Collections
{
    class Program
    {
        //ctrl+k + ctrl+c -> comment all            //ctrl+k + ctrl+u -> uncomment all
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            //In this situation it will write "İlker" but the other ones will disappear.
            names = new string[5];
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);        //nothing written
            Console.WriteLine("*********");

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
