using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLINQ1
{
    internal class PlayList
    {
        private List<Cancion> cancionesLista = new List<Cancion>();
        public void añadir(Cancion c)
        {
            cancionesLista.Add(c);
        }
        public List<Cancion> devolverLista()
        {
            return cancionesLista;
        }

        
        public void Mostrar()
        {
            int numeroCanciones;
            int indiceTipoCancion;
            string estiloCancion;
            int numeroTitulo = 1;
            string tituloCancion;

            List<Cancion> CancionesLista = new List<Cancion>();
            EstilosMusica estilos = new EstilosMusica();

            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "pop");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "rock");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "clasico");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "regueton");
            estilos.Añadir(estilos.GetNumeroElementos() + 1001, "jazz");
            Random aleatorio = new Random();
            numeroCanciones = aleatorio.Next(10, 21);

            for (int i = 0; i < numeroCanciones; i++)
            {
                indiceTipoCancion = aleatorio.Next(1001, 1006);
                tituloCancion = "Titulo " + numeroTitulo;
                estiloCancion = estilos.Consultar(indiceTipoCancion);
                Cancion c = new Cancion(tituloCancion, estiloCancion);
                CancionesLista.Add(c);
                numeroTitulo++;

            }

            foreach (Cancion cancion in CancionesLista)
            {
                Console.WriteLine(cancion);
            }
         
        }
        public List<Cancion> MostrarPorEstilo(string estilo)
        {
            return cancionesLista.Where(x => x.tipoMusica == estilo).ToList(); 
        }

        public List<string> ListaTitulo()
        {
            return cancionesLista.Select(x => x.tituloCancion).ToList<string>();
        }
    }
}
