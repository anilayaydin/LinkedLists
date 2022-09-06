using System;

namespace Algorithms {
    class Program {

        static void Main(string[] args) {
            LinkedList<string> listy = new LinkedList<string>();
            //AddLast
            //AddFirst
            listy.AddLast("Sinan");
            listy.AddLast("Anıl");
            listy.AddLast("Mustafa");
            listy.AddLast("Tayfun");

            Console.WriteLine(listy.Contains("Anıl"));
            Console.WriteLine(listy.Contains("Mustafa"));
            Console.WriteLine(listy.Contains("Tayfun"));
            Console.WriteLine(listy.Contains("Pand"));

            Console.WriteLine(listy.Count);
            listy.RemoveFirst();

            foreach (string item in listy)
            {
                Console.Write(item + "->");
            }

            Console.WriteLine();
        }
    }
}