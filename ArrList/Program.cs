using System.Collections;

namespace ArrList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* ArrayList colores = new ArrayList();
            colores.Add("azul");
            colores.Add("amarillo");
            colores.Add("verde");

            colores.Insert(1, "rojo");

            Console.WriteLine(colores.IndexOf("amarillo"));

            for (int i = 0; i < colores.Count; i++)
            {
                Console.WriteLine(colores[i]);  
            }
           

            foreach (string color in colores){
                Console.WriteLine(color);   

            }
           */

            ArrayList nombres = new ArrayList();
            ArrayList nombresLong = new ArrayList();
            String posibleNombre="";
            bool continuar = true;

            do
            {
                try
                {
                    posibleNombre = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (posibleNombre.Equals("fin"))
                {
                    continuar = false;
                }
                else
                {
                    nombres.Add(posibleNombre);
                }

            } while (continuar);

            Console.WriteLine("\n\nNombres introducidos:");
            foreach (string i in nombres) {
                Console.WriteLine(i);
            }

        }
    }
}