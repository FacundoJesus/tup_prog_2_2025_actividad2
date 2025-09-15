using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Persona
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Persona(int dni, string nombre) {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        public string VerDatos()
        {
            return $@"Nombre: {this.Nombre} - DNI: {this.DNI} ";
        }
    }
}
