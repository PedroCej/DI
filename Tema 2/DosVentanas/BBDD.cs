using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        MySqlDataReader miDataReader;

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
                    miConexion = new MySqlConnection("server = " + ip + ";" + " port = " + port + ";" + " userid = " + user + ";" + " password = " + passwd + ";" + " database = world; Allow Zero DateTime = True; CHARSET = utf8mb4");
                    miConexion.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con el servidor" + ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Desconectar()
        {
            miConexion.Close();
        }
    }
}
