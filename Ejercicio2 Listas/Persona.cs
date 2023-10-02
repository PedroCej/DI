using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Listas
{
    public class Persona
    {
        private string nombre;
        private int longitud;

        public string Nombre // Otra manera 
        {
            set => nombre = value;
            get => nombre; 
        }

        public int Longitud // Formato clasico
        {
            set { 
                longitud = value; 
             }

            get { 
                return longitud;
             }
        }

        public Persona(String nombre)
        {
            this.nombre = nombre;   
            this.longitud = nombre.Length;

        }

        public override string ToString()
        {
            return "Persona: " + nombre+" - "+ longitud;
        }
    }
}
