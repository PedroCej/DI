using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosVentanas
{
    public class BBDD
    {
        string user, passwd, ip, port;

        MySqlConnection miConexion;
        MySqlCommand miComando;
        MySqlDataAdapter miAdaptador;
        DataSet ds;

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

        public void CargarTablaForestales()
        {
            miComando = new MySqlCommand("SELECT * FROM forestales", miConexion);
            miAdaptador = new MySqlDataAdapter(miComando);
            ds = new DataSet();
            miAdaptador.Fill(ds, "forestales");

        }

        public DataRow obtenerFila(int i)
        {
            DataRow fila = ds.Tables[0].Rows[i];
            return fila;
           
        }

        public int numFilas()
{
            return ds.Tables[0].Rows.Count;
        }


        public void Desconectar()
        {
            miConexion.Close();
        }
    }
}
