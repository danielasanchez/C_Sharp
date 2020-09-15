using System;

namespace Example11
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
            AlumnoObj.imprimir();
            Console.ReadKey();
        }
    }
}
