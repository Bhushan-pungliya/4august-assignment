using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Lionel Messi");
            dict.Add(2, "Cristiano Ronaldo");
            dict.Add(3, "Neymar jr.");
            dict.Add(4, "Ronaldinho Gaucho");
            dict.Add(5, "Andres Ineasta");
            Console.WriteLine("-------------The dictionary elements are--------------------");
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Count of element in dictionary : {0}", dict.Count);

            Console.WriteLine("Checking index 2 in dict : {0}", dict.ContainsKey(2));
            Console.WriteLine("Checking Value Andres Ineasta in dict : {0}", dict.ContainsValue("Andres Ineasta"));
            Console.WriteLine("Checking index 7 in di : {0}", dict.ContainsKey(7));

            Console.WriteLine("Removing All element From dict : ");
            dict.Clear();

            foreach (var item1 in dict)
            {
                Console.WriteLine(item1);
            }


            Console.ReadLine();

        }
    }
}