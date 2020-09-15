using System;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros1 = new int[5] { 10, 20, 30, 40, 50 };

            foreach (var item in numeros1)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.WriteLine(numeros1[i]);
            }

        }
    }
}
