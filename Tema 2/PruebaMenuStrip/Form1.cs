namespace PruebaMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es Acerca De");

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
    }
}