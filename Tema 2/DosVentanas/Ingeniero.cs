using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosVentanas
{
    internal class Ingeniero
    {
        public string dni { get; set; }  
        public string nombre { get; set; }    
        public string apellidos { get; set; } 
        public string telefono { get; set; }    
        public string email { get; set; } 
        public Ingeniero(string dni, string nombre, string apellidos, string telefono, string email)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
            this.apellidos = apellidos;
        }
            
        
        }
    }

