using System;
using System.Collections.Generic;
using System.Data;
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


        public void CrearUsuario(String usuario, String contraseña, String foto)
        {
            comando = new SQLiteCommand($"INSERT INTO Logins ('Usuario','Pass','FotoPerfil') VALUES ('{usuario}','{contraseña}','{foto}');", conexion);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { }


        }


        public bool LoginTry(String usuario, String contraseña)
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
