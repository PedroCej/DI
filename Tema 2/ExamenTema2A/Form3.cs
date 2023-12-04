using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTema2A
{
    public partial class Form3 : Form
    {
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string telefono;
        public Form3(string nombre, string apellido1, string apellido2, string telefono)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtApellido11.Text = apellido1;
            txtApellido21.Text = apellido2;
            txtTelefono.Text = telefono;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
