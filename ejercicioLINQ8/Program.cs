namespace ejercicioLINQ8
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>()
                {
                new Alumno("Eva",20,6.0),
                new Alumno("Ana",22,7.0),
                new Alumno("Rosa",22,4.0),
                new Alumno("Ot",20,3.0),
                new Alumno("Iu",30,6.8),
                new Alumno("Pep",32,5.9),
                new Alumno("Laia",30,2.3),
                new Alumno("Quim",32,1.7),
                };

            List<Alumno> ejer1 = listaAlumnos.Where(x => x.Edad >30);
        
        }

       

    }
}