using System;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("Menu de Opciones");
                Console.WriteLine("a) Calcular el promedio de “n” números ");
                Console.WriteLine("b) Calcular la tabla de multiplicar de “x” numero ");
                Console.WriteLine("c) Identificar si “x” numero es par o impar");
                Console.WriteLine("<ESC> Salir");

                opcion = Console.ReadKey();
                switch (opcion.KeyChar)// opcion.Key
                {
                    case 'a': // ConsoleKey.A: 
                        break;
                    case 'b':
                        break;
                    case 'c':
                        break;
                    default:
                        if (opcion.Key != ConsoleKey.Escape)
                        {
                            Console.WriteLine("Diste una opcion invalida...");
                        }
                        else
                        {
                            Console.WriteLine("Hasta Pronto ...");
                        }
                        break;
                }//fin  switch 

            } while (opcion.Key != ConsoleKey.Escape);


        }
    }
}
