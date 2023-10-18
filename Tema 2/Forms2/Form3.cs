using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    public partial class Form3 : Form
    {

        Form1 formularioRecibido;

        public Form3(Form1 formularioRecibido)
        {
            InitializeComponent();
            this.formularioRecibido = formularioRecibido;
            // formularioRecibido.Size = new System.Drawing.Size(formularioRecibido.Width, formularioRecibido.Height);
        }

        private void rdb1_Click(object sender, EventArgs e)
        {
            formularioRecibido.Size = new System.Drawing.Size(640, 480);
        }

        private void rdb2_Click(object sender, EventArgs e)
        {
            formularioRecibido.Size = new System.Drawing.Size(800, 600);
        }

        private void rdb3_Click(object sender, EventArgs e)
        {
            formularioRecibido.Size = new System.Drawing.Size(1024, 768);
        }
    }
}
