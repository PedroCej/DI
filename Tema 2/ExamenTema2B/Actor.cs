using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema2B
{
    public class Actor
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public Actor(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }


    }
}
