using System;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = false;
            byte NumeroEntero = 0;
            while (bandera == false)
            {
                try
                {
                    Console.Write("Dame Numero: ");
                    NumeroEntero = Convert.ToByte(Console.ReadLine());
                    bandera = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }

            }
            Console.WriteLine("el numero es: {0}", NumeroEntero);
            Console.ReadKey();
        }
    }
}
