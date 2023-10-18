using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLINQ1
{
    internal class Cancion
    {
        public string tituloCancion { get; set; }
        public string tipoMusica { get; set; }
        public Cancion(string tituloCancion, string tipoMusica) {
            this.tituloCancion = tituloCancion;
            this.tipoMusica = tipoMusica;   
        }
        public override string ToString()
        {
            return "La Cancion " + this.tituloCancion + " es musica "+ this.tipoMusica;
        }


    }
}
