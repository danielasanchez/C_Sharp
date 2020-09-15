using System;
using System.Collections.Generic;
using System.Text;

namespace Example10
{
    class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
