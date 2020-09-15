using System;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre del alumno: ");
            string nombre = Console.ReadLine();
            Console.Write("Carrera: ");
            string carrera = Console.ReadLine();

            Alumno AlumnoObj = new Alumno(nombre, carrera);

            Console.ReadKey();

        }
    }
}
