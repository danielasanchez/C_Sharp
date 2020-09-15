using System.Linq;

namespace Example9
{
    class Alumno
    {
        private string nombre;
        private string carrera;
        private byte semestre;
        private double[] calificaciones;

        public string NombrePropiedad
        {
            get
            { return nombre; }
            set
            { nombre = value; }
        }

        public string CarreraPropiedad
        {
            get
            { return carrera; }
            set
            { carrera = value; }
        }

        public byte SemestrePropiedad
        {
            get
            { return semestre; }
            set
            { semestre = value; }
        }

        public double[] CalificacionesPropiedad
        {
            get
            { return calificaciones; }
            set
            { calificaciones = value; }
        }


        public Alumno(string nombre2, string carrera2, byte semestre2, double[] calificaciones2)
        {
            this.nombre = nombre2;   // comenten esta linea y activen la de abajo
            //this.nombre = "Juan Perez"; //y Miren lo que pasa si se le asigna un valor aqui
            this.carrera = carrera2;
            this.semestre = semestre2;
            this.calificaciones = calificaciones2;
        }

        public double promedio(double[] calificaciones)
        {
            double promedio = calificaciones.Sum() / calificaciones.Length;
            return promedio;
        }

    }
}
