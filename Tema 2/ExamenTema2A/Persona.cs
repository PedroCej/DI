using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema2A
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string appellido1, string apellido2, string telefono) {
            Nombre = nombre;
            Apellido1 = appellido1;
            Apellido2 = apellido2;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return Apellido1 + " " + Apellido2;
        }
    }
}
