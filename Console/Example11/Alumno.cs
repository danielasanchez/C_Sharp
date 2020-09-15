using System;
using System.Collections.Generic;
using System.Text;

namespace Example11
{
    public class Alumno : Persona
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

        public override void imprimir()
        {
            Console.WriteLine("hola desde alumno");
        }

        //IMPORTANTE: Esto no es sobrecarga ni polimorfirmo
        public void imprimir2()
        {
            Console.WriteLine("hola desde alumno2");
        }


    }


}
