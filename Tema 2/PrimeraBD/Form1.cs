using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace PrimeraBD
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
            btnMostrar.Enabled = true;
            btnInsertar.Enabled = true;
            miBaseDatos = new BBDD(txtUser.Text, txtPasswd.Text, txtServer.Text, txtPort.Text);
            miBaseDatos.Conectar();


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            miBaseDatos.CargarTablaForestales();
            dataGridView1.DataSource = miBaseDatos.ObtenerDataView();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.Text = Regex.Replace(txtTelefono.Text, "[^0-9]", "");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellidos.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtEmail.Text.Length == 0 ) {
                MessageBox.Show("No puede haber ningún campo vacío");
            }
            else
            {
                miBaseDatos.InsertarTablaForestales(txtDNI.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
              /*  miBaseDatos.CargarTablaForestales();
                dataGridView1.DataSource = miBaseDatos.ObtenerDataView();
              
               //  AÑADIR ESTO SI QUIERO ACTUALIZAR LA TABLA AL INSERTAR
               */
            }
        }
    }
}