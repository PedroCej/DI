using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace ProyectoPruebas.BBDD
{
    
    public class BBDD
    {   
        public bool EstadoBBDD { get; set; }
        public BBDD() 
        {
            EstadoBBDD = false;
        }
        public void ConectarBBDD()
        {
            EstadoBBDD = true;
        }

        public void DesconectarBBDD()
        {
            EstadoBBDD = false;
        }
    }

}
