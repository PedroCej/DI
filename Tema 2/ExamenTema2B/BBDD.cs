using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ExamenTema2B
{
    public class BBDD
    {
        private string ip, port, user, passwd;
        MySqlConnection conexion;    
        public BBDD(string ip, string user, string passwd, string port) 
        {
            this.ip = ip;
            this.user = user;   
            this.passwd = passwd;   
            this.port = port;
        }

        public bool Conectar()
        {
            try
            {
                conexion = new MySqlConnection($"server = {ip}; port = {port}; userid = {user}; password = {passwd}; database = sakila; Allow Zero DateTime = True; CHARSET = utf8mb4")
                conexion.Open();
                return true;
            }catch (Exception ex) 
            { 
                MessageBox.Show("Error")
                    return false;
            }
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public List<Actor> listaActores()
        {
            List<Actor> result = new List<Actor>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM actor", conexion);
            Conectar();
            MySqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Actor nuevoActor = new Actor(Convert.ToInt16(dr["actor_id"]), dr["first_name"].ToString(), dr["last_name"].ToString());
                result.Add(nuevoActor);
            }
            return result;
        }

        public EliminarActor (int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM actor WHERE ID="+id+"");
            Conectar();
            comando.ExecuteNonQuery();
        }

        public DataSet DataSetPeliculas(int id)
        {
            DataSet ds = new DataSet();
            MySqlCommand comando = new MySqlCommand($"SELECT f.* FROM film f, actor a, film_actor fa WHERE fa.actor_id ={id} AND fa.film_id = f.film_id", conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            Conectar();
            adapter.Fill(ds, "peliculas");
            return ds;
        }
        
        public DataView DataViewPeliculas (int id)
        {
            return DataSetPeliculas(id).Tables[0].DefaultView;
        }
    }
}
