using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = comboBox1.Text.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Coche> listaCoches = new List<Coche>(new Coche("",""));


            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Mercedes");
            comboBox1.Items.Add("Ferrari");
            comboBox1.Items.Add("Ford");
            comboBox1.Items.Add("Seat");
            comboBox1.Items.Add("Porsche");


        }
    }
}
