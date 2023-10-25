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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = comboBox1.Text.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("BMW");
            comboBox1.Items.Add("Mercedes");
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Ferrari");
            comboBox1.Items.Add("Ford");
            
            comboBox1.SelectedIndex = 2;
        }
    }
}
