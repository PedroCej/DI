using MySql.Data.MySqlClient;
using System.Data;

namespace EjercicioListasCiudades
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        BBDD miBaseDatos;
        private void btnConectar_Click(object sender, EventArgs e)
        {
            miBaseDatos = new BBDD(txtUser.Text, txtPasswd.Text, txtServer.Text, txtPort.Text);
            miBaseDatos.Conectar();

        }
    }
}