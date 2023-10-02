namespace Ejercicio2_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Persona> listaPersonas = new List <Persona>();
            bool cont = true;
            string posiblePersona = "";

            do
            {
                
                try
                {
                    posiblePersona = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                if (posiblePersona.Equals("fin"))
                {
                    cont = false;
                }
                else
                {
                    Persona nuevaPersona = new Persona(posiblePersona);
                    listaPersonas.Add(nuevaPersona);
                }

            } while (cont);

            foreach (Persona persona in listaPersonas)
            {
                Console.WriteLine(persona);
            }
            
        }
    }
}