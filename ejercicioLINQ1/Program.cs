using System.Security.Cryptography.X509Certificates;

namespace ejercicioLINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayList playList = new PlayList();
            playList.Mostrar();

            playList.MostrarPorEstilo("rock");
            



/*
            List<Cancion> BusquedaPorEstilo(string estilo)
           {
                /*List<Cancion> ListaDevolver = new List<Cancion>();
                foreach(Cancion miCancion in CancionesLista)
                {
                    if(miCancion.tipoMusica == estilo) { 
                        ListaDevolver.Add(miCancion);
                    }
                }
                return ListaDevolver;
            

                return CancionesLista.Where(x => x.tipoMusica==estilo).ToList();
            }
*/

        }
    }
}