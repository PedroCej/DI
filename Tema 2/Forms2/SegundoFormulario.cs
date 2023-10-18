using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    public partial class SegundoFormulario : Form
    {
        Form1 formularioRecibido;

        public SegundoFormulario(Form1 formularioRecibido)
        {
            InitializeComponent();
            this.formularioRecibido = formularioRecibido;
        }

        public SegundoFormulario(Form1 formularioRecibido, string mensaje)
        {
            InitializeComponent();
            this.formularioRecibido = formularioRecibido;
            etiquetaForm2.Text = mensaje;

        }

        private void SegundoFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioRecibido.Show();
        }
    }
}
