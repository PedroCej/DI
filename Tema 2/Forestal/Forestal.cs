using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forestal
{
    public class Forestal
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public override string ToString()
        {
            return Apellido1 + ", " + Nombre;
        }

        public Forestal(string a, string b, string c, string d) { 
            Nombre = a;
            Apellido1 = b;  
            Apellido2 = c;
            Telefono = d;
        }

    }
}
