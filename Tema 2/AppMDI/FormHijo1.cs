using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMDI
{
    public partial class FormHijo1 : Form
    {

        public FormHijo1(String textoAsignar)
        {
            InitializeComponent();
            richTextBox1.Text = textoAsignar;
        }

        public string get_TxtBox()
        {
            return richTextBox1.Text;
        }

        private void FormHijo1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FormPadre)MdiParent).EliminarDeLaLista(this);
        }
    }
}
