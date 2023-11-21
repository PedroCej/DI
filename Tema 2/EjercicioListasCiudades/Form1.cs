using MySql.Data.MySqlClient;
using System.Data;

namespace EjercicioListasCiudades
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

            List<Ciudad> listaCiudades = miBaseDatos.ObtenerCiudades();
            foreach (Ciudad ciudad in listaCiudades)
            {
                listBox1.Items.Add(ciudad);
            }
        }
    }
}