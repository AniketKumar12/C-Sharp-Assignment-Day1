using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static string[] words = new string[] { "Boat", "House", "Cat", "River", "Cupboard" };
        static void Main(string[] args)
        {
            Console.WriteLine("Plurals:-");
            foreach (var w in words)
                Console.WriteLine(w + "s");
            

            Console.WriteLine("\nReplaced:-");
            words[1] = "home";
            foreach (var w in words)
                Console.WriteLine(w);

            Console.WriteLine("\nnew word:-");
            List<string> word = words.ToList();
            word.Add("Dog");
            words = word.ToArray();
            foreach (var w in words)
                Console.WriteLine(w);
        

            Console.WriteLine("\nWords:-");
            var wordlen = Array.FindAll(words, r => r.Length == 7);
            foreach (var w in wordlen)
                Console.WriteLine(w);

            Console.WriteLine("\n3rd Word Position:-{0}",words[2]);
           
            

            Console.WriteLine("\nAscending Order:-");
            var ascending = words.OrderBy(r => r);
            foreach (var w in ascending)
                Console.WriteLine(w);
            
            Console.WriteLine("\nReverse Order:-");
            var reverse = words.Reverse();
            foreach (var w in reverse)
                Console.WriteLine(w);

            /*  for (int i = 0; i < words.Count; i++)
              {
                  if(words[i].EndsWith('y'))
                  {
                      int a = words[i].LastIndexOf('y');

                      words[i]=substring + "ies";
                  }
                  else
                  {
                      words[i] = words[i] + "es";
                  }

                  Console.WriteLine(words[i]);
              }*/

        }
    }
}
