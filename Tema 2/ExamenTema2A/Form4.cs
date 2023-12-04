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
    public partial class Form4 : Form
    {
        List<Persona> personaList;
        public Form4(List<Persona> personaList)
        {
            InitializeComponent();
            this.personaList = personaList;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            personaList.RemoveAt(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = personaList;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = personaList;
        }
    }
}
