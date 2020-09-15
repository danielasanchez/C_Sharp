using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int matricula;
            byte semestre;
            float calf1, calf2, calf3;
            double promedio;

            Console.Write("Alumno: ");
            nombre = Console.ReadLine();
            Console.Write("Matricula: ");
            matricula = Convert.ToInt16(Console.ReadLine());
            Console.Write("Semestre: ");
            semestre = Convert.ToByte(Console.ReadLine());
            Console.Write("Calificacion 1: ");
            calf1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Calificacion 2: ");
            calf2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Calificacion 3: ");
            calf3 = Convert.ToSingle(Console.ReadLine());

            promedio = (calf1 + calf2 + calf3) / 3;

            Console.WriteLine(promedio);
        }
    }
}
