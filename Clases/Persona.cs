using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Persona
    {

        private string nombre;
        private string apellido;
        private DateTime fecha;
        private int edad;


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }   

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Edad
        {
            get { return edad=DateTime.Now.Year-fecha.Year; }
            set { edad = value; }
        }   


    }
}
