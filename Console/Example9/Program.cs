using System;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre del alumno: ");
            string nombreCapturado = Console.ReadLine();
            Console.Write("Carrera: ");
            string carreraCapturado = Console.ReadLine();
            Console.Write("Semestre: ");
            byte semestreCapturado = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("****Dame las Calificaciones****");
            double[] calificacionesCapturado = new double[5];

            for (int i = 0; i < calificacionesCapturado.Length; i++)
            {
                Console.Write("Calificacion " + (i + 1) + ": ");
                calificacionesCapturado[i] = Convert.ToDouble(Console.ReadLine());
            }

            Alumno AlumnoObj = new Alumno(nombreCapturado, carreraCapturado, semestreCapturado, calificacionesCapturado);

            // double promedio = AlumnoObj.promedio(calificaciones);

            //AlumnoObj.NombrePropiedad = "Daniela";
            //AlumnoObj.CarreraPropiedad = "Informatica";
            //AlumnoObj.SemestrePropiedad = 6;

            Console.WriteLine("El alumno " + AlumnoObj.NombrePropiedad + "\ncarrera " + AlumnoObj.CarreraPropiedad);
            //Console.WriteLine("El alumno " + AlumnoObj.NombrePropiedad + " tiene un promedio de: " + promedio);


            Console.ReadKey();
        }
    }
}
