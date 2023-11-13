using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forestal
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        int pos;
        public Form3(Form1 form1, int pos)
        {
            InitializeComponent();
            this.form1 = form1;
            this.pos = pos;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = form1.consultarLista(pos).Nombre;
            textBox2.Text = form1.consultarLista(pos).Apellido1;
            textBox3.Text = form1.consultarLista(pos).Apellido2;
            textBox4.Text = form1.consultarLista(pos).Telefono;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
