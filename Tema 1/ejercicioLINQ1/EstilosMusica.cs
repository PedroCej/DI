using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLINQ1
{
    internal class EstilosMusica
    {
        private Dictionary<int, string> tiposMusica = new Dictionary<int, string>();
        public void Añadir(int n, string s) { 
            tiposMusica.Add(n, s);
        }

        public string Consultar(int n)
        {
            return tiposMusica[n];
        }

        public int GetNumeroElementos()
        {
            return tiposMusica.Count;
        }
    }
}
