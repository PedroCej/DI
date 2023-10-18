using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalProductos = intAleatorio(1,8);
            double precioFinal = 0;
            Console.WriteLine("Se han creado " + totalProductos +" productos");
            Console.WriteLine("\n  Nombre     Cantidad\t  Precio\t\t  TOTAL");

            Queue<Producto> ticket = new Queue<Producto>();  

            for (int i = 0; i < totalProductos; i++) { 
                Producto producto = new Producto(intAleatorio(1,10), doubleAleatorio(1,50)); // Crea los 8 tipos de productos
                Console.WriteLine("Producto" + i + "\t" + producto.getCantidad() + "\t" + producto.getPrecio() + "\t" + producto.getCantidad() * producto.getPrecio());
                ticket.Enqueue(producto);
            }

            for (int i = 0; i < totalProductos; i++)
            {
                Producto producto = ticket.Dequeue();
                precioFinal += producto.getCantidad() * producto.getPrecio();
            }

            Console.WriteLine("\n\n\tPRECIO FINAL: " + precioFinal);


        }


        public static int intAleatorio(int minimo, int maximo)
        {
            Random al = new Random();
            return al.Next(minimo, maximo);
        }

        public static double doubleAleatorio(int minimo, int maximo)
        {
            Random al = new Random();
            return al.NextDouble() * (maximo - minimo) + minimo;
        }

    }
}