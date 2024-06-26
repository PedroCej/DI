﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinal0.Datos
{
    public class BBDD
    {
        SQLiteConnection conexion;
        SQLiteCommand comando;
        SQLiteDataAdapter adaptador;
        DataSet ds;
        public BBDD() 
        {
            Conectar();
        }

 
        public void Conectar()
        {
            conexion = new SQLiteConnection("Data Source = C:\\Users\\perki\\Desktop\\DI\\Tema 5\\ProyectoFinal0\\Datos\\miDB.db; Version = 3; New = False; Compress = True; ");
            conexion.Open();
          
        }// fin conectar


        public void CrearUsuario(String usuario, String contrasena, String foto)
        {
            comando = new SQLiteCommand($"INSERT INTO Logins ('Usuario','Pass','FotoPerfil') VALUES (@usuario,@contrasena,'{foto}');", conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }


        public void EliminarUser(string user)
        {
            comando = new SQLiteCommand($" DELETE FROM Logins WHERE Usuario='{user}' ", conexion);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { }

        }

        public List<string> getUsuarios()
        {
            comando = new SQLiteCommand($"SELECT * FROM Logins", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Logins");
            List<string> lista = new List<string>();
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                lista.Add(fila["Usuario"].ToString());
            }
            return lista;
        }

        public string getFoto(string usuario)
        {
            comando = new SQLiteCommand($"SELECT * FROM Logins WHERE Usuario='{usuario}'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Logins");
            return ds.Tables[0].Rows[0]["FotoPerfil"].ToString();
               
        }

        public bool RegisterTry(String usuario)
        {
            comando = new SQLiteCommand($"SELECT * FROM Logins WHERE Usuario='{usuario}'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();

            try
            {
                adaptador.Fill(ds, "Logins");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
            }catch (Exception ex) {
                return false;
            }
            return false;
        }

        public int getNumUsers()
        {
            int cant = 0;
            comando = new SQLiteCommand($"SELECT * FROM Logins", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Logins");

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Logins"].Rows)
                {
                    cant++;
                }
            }
            return cant;
        }


        //
        // METODOS PARA FAVORITOS
        //
        public void guardarPersonaje(int id, string user, string nombre, string imagen)
        {
            
            comando = new SQLiteCommand($"INSERT INTO Personajes ('id','Usuario','Nombre','Imagen')" +
                $" VALUES ('{id}','{user}','{nombre}','{imagen}');", conexion);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        public List<string> getPersonajesGuardados(string user)
        {
            comando = new SQLiteCommand($"SELECT * FROM Personajes WHERE Usuario='{user}'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Personajes");
            List<string> lista = new List<string>();

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Personajes"].Rows)
                {
                    lista.Add(row[1].ToString());
                }
            }
            return lista;
        }
        public string getIdGuardado(string nombre)
        {
            comando = new SQLiteCommand($"SELECT id FROM Personajes WHERE Nombre='{nombre}'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Personajes");
            string id="";

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Personajes"].Rows)
                {
                    id = row[0].ToString();
                }
            }
            return id;
        }

        public List<string> getFotosGuardadas(string user)
        {
            comando = new SQLiteCommand($"SELECT Imagen FROM Personajes WHERE Usuario='{user}'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Personajes");
            List<string> lista = new List<string>();

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Personajes"].Rows)
                {
                    lista.Add(row[0].ToString());
                }
            }
            return lista;
        }

        public int getNumeroPersonajesGuardados(string user)
        {
            int cant = 0;
            comando = new SQLiteCommand($"SELECT * FROM Personajes WHERE Usuario='{user}'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Personajes");

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Personajes"].Rows)
                {
                    cant++;
                }
            }
            return cant;
        }

        

        //
        //  METODOS DEL ADMIN
        //
        public List<string> getAllUsers()
        {
            List<string> lista= new List<string>();
            comando = new SQLiteCommand($"SELECT * FROM Logins", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Logins");

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables["Logins"].Rows)
                {
                    lista.Add(row[1].ToString());
                }
            }
            return lista;
        }
        
        public bool EsAdmin(String usuario)
        {
            comando = new SQLiteCommand($"SELECT * FROM Logins WHERE Usuario='{usuario}' AND TipoUsuario='0'", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            try
            {
                adaptador.Fill(ds, "Logins");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true; // es admin
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public bool LoginTry(String usuario, String contrasena)
        {
            comando = new SQLiteCommand($"SELECT * FROM Logins WHERE Usuario=@usuario AND Pass=@contrasena", conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            try
            {
                adaptador.Fill(ds, "Logins");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true; // existe ese registro
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        /*
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellidos = textBox2.Text;
            int id = dataGridView1.SelectedRows[0].Index + 1;
            comando = new SQLiteCommand($"UPDATE Persona SET Nombre='{nombre}', Apellidos='{apellidos}' WHERE ID=" + id + "", conexion);
            comando.ExecuteNonQuery();

            this.actualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.SelectedRows[0].Index + 1;
            comando = new SQLiteCommand($"DELETE FROM Persona WHERE ID=" + id + "", conexion);
            comando.ExecuteNonQuery();

            this.actualizarLista();
        }

        */

    }
}
