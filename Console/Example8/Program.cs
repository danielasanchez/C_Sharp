using System;
using System.Collections.Generic;

namespace Example8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num_art = new List<int>();
            num_art.Add(123);
            num_art.Add(234);
            num_art.Add(332);
            num_art.Add(443);
            num_art.Add(532);

            for (int i = 0; i < num_art.Count; i++)
            {
                Console.WriteLine("Num.Art. {0}", num_art[i]);
            }

            foreach (var i in num_art)
            {
                Console.WriteLine("Num.Art. {0}", i);
            }



        }
    }
}
