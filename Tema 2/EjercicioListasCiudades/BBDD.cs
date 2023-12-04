using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
            
                try
                {
                    miConexion = new MySqlConnection($"server = {"localhost"}; port = {port}; userid = {user}; password = {passwd}; database = world; Allow Zero DateTime = True; CHARSET = utf8mb4");
                    //$"server = [ip]; port = [port]; userid = [user]; password = [passwd]; database = world; Allow Zero DateTime = True; CHARSET = utf8mb4"
                    miConexion.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con el servidor" + ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        public List<Ciudad> ObtenerCiudades()
        {
            List<Ciudad> listaCiudades = new List<Ciudad>();
            Conectar();
            miComando = new MySqlCommand("SELECT * FROM city", miConexion);
            miDataReader = miComando.ExecuteReader();
            while (miDataReader.Read())
            {
                Ciudad city = new Ciudad((Int32)miDataReader["ID"], miDataReader["Name"].ToString(), miDataReader["CountryCode"].ToString(), (Int32)miDataReader["Population"]);
                listaCiudades.Add(city);
            }
            Desconectar();
            return listaCiudades;
        }

        public List<Ciudad> ObtenerCiudades(string codigoPais)
        {
            List<Ciudad> listaCiudades = new List<Ciudad>();
            Conectar();
            miComando = new MySqlCommand($"SELECT * FROM city WHERE CountryCode='{codigoPais}'", miConexion);
            miDataReader = miComando.ExecuteReader();
            while (miDataReader.Read())
            {
                Ciudad city = new Ciudad((Int32)miDataReader["ID"], miDataReader["Name"].ToString(), miDataReader["CountryCode"].ToString(), (Int32)miDataReader["Population"]);
                listaCiudades.Add(city);
            }
            Desconectar();
            return listaCiudades;
        }

        public Pais obtenerPais(string ip)
        {
            Conectar();
            miComando = new MySqlCommand($"SELECT * FROM country where code='{ip}'", miConexion);
            miDataReader =  miComando.ExecuteReader();
            miDataReader.Read();
            Pais pais = new Pais(miDataReader["Code"].ToString(), miDataReader["Name"].ToString(), miDataReader["Continent"].ToString(), Convert.ToInt32(miDataReader["SurfaceArea"]) , (Int32)miDataReader["Population"], (decimal)miDataReader["LifeExpectancy"]);
            Desconectar();    
            return pais;
           
        }

        public List<Pais> obtenerPaises()
        {
            List<Pais> listaPaises = new List<Pais>();
            Conectar();
            miComando = new MySqlCommand("SELECT * FROM country", miConexion);
            miDataReader = miComando.ExecuteReader();
            while (miDataReader.Read())
            {
                decimal esperanza;
                if (miDataReader[7] == DBNull.Value) esperanza = 0;
                else esperanza = Convert.ToDecimal(miDataReader[7]);
                Pais nuevoPais = new Pais(miDataReader["Code"].ToString(), miDataReader["Name"].ToString(), miDataReader["Continent"].ToString(), Convert.ToInt32(miDataReader["SurfaceArea"]), (Int32)miDataReader["Population"], esperanza);
                listaPaises.Add(nuevoPais);
            }
            Desconectar();
            return listaPaises;

        }

        public void Desconectar()
        {
            miDataReader.Close();
            miConexion.Close();
            
        }
    }
}
