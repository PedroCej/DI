using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PruebaMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ToolStripMenuItem_Archivo_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_Operaciones_Sumar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;
                resultado = int.Parse(txtA.Text) + int.Parse(txtB.Text);
                lbl1.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItem_Operaciones_Restar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;
                resultado = int.Parse(txtA.Text) - int.Parse(txtB.Text);
                lbl1.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItem_Operaciones_Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;
                resultado = int.Parse(txtA.Text) * int.Parse(txtB.Text);
                lbl1.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItem_Operaciones_Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado;
                resultado = double.Parse(txtA.Text) / double.Parse(txtB.Text);
                lbl1.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStripTextA_Resetear_Click(object sender, EventArgs e)
        {
            txtA.Text = null;
        }

        private void contextMenuStripTextA_CalcularAleatorio_Click(object sender, EventArgs e)
        {
            txtA.Text = new Random().Next(0, 100).ToString();
        }

        private void resetearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = null;
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = new Random().Next(0, 100).ToString();//
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es Acerca De");
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Enabled = habilitarToolStripMenuItem.Checked;
            txtB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                this.BackColor = color.Color;
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                txtA.ForeColor = color.Color;
                txtB.ForeColor = color.Color;
                lbl1.ForeColor = color.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                txtA.Font = fuente.Font;
                txtB.Font = fuente.Font;
                lbl1.Font = fuente.Font;
            }

        }
    }
}