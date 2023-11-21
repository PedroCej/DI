using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListasCiudades
{
    internal class BBDD
    {
        string user, passwd, ip, port;

        MySqlConnection miConexion;
        MySqlCommand miComando;
        MySqlDataAdapter miAdaptador;
        DataSet miDataSet;

        public BBDD(string user, string passwd, string ip, string port)
        {
            this.user = user;
            this.passwd = passwd;
            this.ip = ip;
            this.port = port;
        }

        public void Conectar()
        {
            if (miConexion != null) miConexion.Close();
            else
            {
                try
                {
                    miConexion = new MySqlConnection("server = " + ip + ";" + " port = " + port + ";" + " userid = " + user + ";" + " password = " + passwd + ";" + " database = ingenieros; Allow Zero DateTime = True; CHARSET = utf8mb4");
                    miConexion.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con el servidor" + ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /*
        public void CargarTablaForestales()
        {
            miComando = new MySqlCommand("SELECT * FROM forestales", miConexion);
            miAdaptador = new MySqlDataAdapter(miComando);
            miDataSet = new DataSet();
            miAdaptador.Fill(miDataSet, "forestales");
        }

        public void InsertarTablaForestales(string dni, string nombre, string apellidos, string telefono, string email)
        {
            miComando = new MySqlCommand("INSERT INTO FORESTALES VALUES('" + dni + "','" + nombre + "','" + apellidos + "','" + telefono + "','" + email + "')", miConexion);
            miComando.ExecuteNonQuery();
        }

        public DataView ObtenerDataView()
        {
            return miDataSet.Tables["Forestales"].DefaultView;
        }

        public void Desconectar()
        {
            miConexion.Close();
        }
        */
    }
}
