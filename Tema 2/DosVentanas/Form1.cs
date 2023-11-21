using MySql.Data.MySqlClient;

namespace DosVentanas
{
    public partial class Form1 : Form
    {
        BBDD miBaseDatos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            miBaseDatos = new BBDD(txtUser.Text, txtPasswd.Text, txtServer.Text, txtPort.Text);
            miBaseDatos.Conectar();
            this.Hide();
            Form2 segundaPagina = new Form2(this, miBaseDatos);
            segundaPagina.ShowDialog();
        }


    }
}