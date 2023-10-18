namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Informe> stack = new Stack<Informe>();

            for (int i = 0; i < 10; i++) { // Agrega los 10 primeros informes
                Informe informe = new Informe(i,generaNumeroAleatorio(0,3));
                stack.Push(informe);
            }

            Console.WriteLine("\nLos ultimos 3 informes: "); 
            for (int i = 0;i < 3;i++) {
                Console.WriteLine(stack.Pop());
            }

            for (int i = 0; i < 5; i++)
            { // Agrega 5 informes
                Informe informe = new Informe(i+10, generaNumeroAleatorio(0, 3));
                stack.Push(informe);
            }

            Console.WriteLine("\n Todos los informes: ");
            for(int i = 0;stack.Count > 0;i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public static int generaNumeroAleatorio(int minimo, int maximo)
        {
            Random al = new Random();
            return al.Next(minimo, maximo);
        }
    }
}