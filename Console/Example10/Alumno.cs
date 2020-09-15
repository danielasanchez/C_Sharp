using System;
using System.Collections.Generic;
using System.Text;

namespace Example10
{
    class Alumno : Persona
    {
        private string carrera;

        public string Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }

        public Alumno(string nombre, string carrera) : base(nombre)
        {
            this.Carrera = carrera;
        }
    }

}
