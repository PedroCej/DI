using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListasCiudades
{
    public class Pais
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public int SurfaceArea { get; set; }
        public int Population { get; set;}
        public decimal lifeExpectancy { get; set; }

        public Pais(string code, string name, string continent, int surface, int popu, decimal life)
        {
            this.Code = code;
            this.Name = name;
            this.Continent = continent;
            this.SurfaceArea = surface;
            this.Population = popu;
            this.lifeExpectancy = life;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
