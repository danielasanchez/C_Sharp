using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Comentario

            /*Esto es un comentario
            de varios renglones*/

            byte calf1 = 100;
            byte calf2 = 90;
            byte calf3 = 95;
            byte calf4 = 97;

            Console.WriteLine("Calificacion 1: {0}, Calificacion 2: {1}, Calificacion 3: {2}, Calificacion 4: {3}", calf1, calf2, calf3, calf4);
            Console.WriteLine("Calificacion 1: " + calf1 + ", Calificacion 2: " + calf2 + ", Calificacion 3: " + calf3 + ", Calificacion 4: " + calf4);
            Console.WriteLine($"Calificacion 1: {calf1}, Calificacion 2: {calf2}, Calificacion 3: {calf3}, Calificacion 4: {calf4}");
            
            Console.ReadKey();


        }
    }
}
