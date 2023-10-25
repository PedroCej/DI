namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es un cuadro de dialogo modal, fijate que hasta que no lo cierres no volveras al formulario principal.", "Titulo");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Aquamarine;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            SegundoFormulario nuevoForm = new SegundoFormulario(this, txtMensaje.Text);
            nuevoForm.Show();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form3 nuevoForm = new Form3(this);
            nuevoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 nuevoForm = new Form4();
            nuevoForm.Show();
        }
    }
}