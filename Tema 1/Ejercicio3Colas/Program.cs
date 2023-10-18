namespace Ejercicio3Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPersonas = generaNumeroAleatorio(0,50);
            Console.WriteLine("Hay " + numPersonas + " personas en el cine.");
            Queue<Persona> lista = new Queue<Persona>();
            int recaudacion=0;

            for (int i = 0; i < numPersonas; i++) {  // Entran las personas
                Persona persona = new Persona(generaNumeroAleatorio(5,60));
                lista.Enqueue(persona);

                if (persona.getEdad() <= 10) { recaudacion += 3; }
                else if(persona.getEdad() <= 17) { recaudacion+= 5; }
                else { recaudacion+= 7; }

                Console.WriteLine("Ha pagado una persona con "+ persona.getEdad()+ " años.");
                Console.WriteLine("Total: " + recaudacion);
                lista.Dequeue();
            }

            if (lista.Count() == 0) Console.WriteLine("\n\nNo hay nadie en la cola");

        }


        public static int generaNumeroAleatorio(int minimo, int maximo)
        {
            Random al = new Random();
            return al.Next(minimo, maximo);
        }
    }
}