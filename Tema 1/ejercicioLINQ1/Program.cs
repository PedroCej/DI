using System.Security.Cryptography.X509Certificates;

namespace ejercicioLINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayList playList = new PlayList();
            playList.Mostrar();
            List<Cancion> cancionesPorEstilo = playList.MostrarPorEstilo("rock");

            //Console.WriteLine(playList.MostrarPorEstilo("rock"));

            //Console.WriteLine(playList.ListaTitulo());
            //playList.MostrarPorEstilo("rock");
            foreach (Cancion cancion in cancionesPorEstilo) { 
                Console.WriteLine(cancion.tipoMusica);
            }

            cancionesPorEstilo.

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