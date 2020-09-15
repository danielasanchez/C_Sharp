using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame Numero: ");
            string NumeroCadena = Console.ReadLine();
            byte NumeroEntero;

            while (byte.TryParse(NumeroCadena, out NumeroEntero) == false)
            {
                Console.WriteLine("Este dato no es numerico, intenta otra vez");
                Console.Write("Dame Numero: ");
                NumeroCadena = Console.ReadLine();
            }

            Console.WriteLine("el numero es: {0}", NumeroEntero);
            Console.ReadKey();

        }
    }
}
