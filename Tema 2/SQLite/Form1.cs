using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using static System.Net.WebRequestMethods;


namespace SQLite
{
    public partial class Form1 : Form
    {
        SQLiteConnection conexion;
        SQLiteCommand comando;
        SQLiteDataAdapter adaptador;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            String strFilePath = Path.Combine(strAppPath, "Resources");
            String strFullFilename = Path.Combine(strFilePath, "BDSQLite.db");
            conexion = new SQLiteConnection("Data Source = " + strFullFilename + " ; Version = 3; New = False; Compress = True; ");
            conexion.Open();
            btnLeer.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void actualizarLista()
        {
            comando = new SQLiteCommand("SELECT * FROM Persona", conexion);
            adaptador = new SQLiteDataAdapter(comando);
            ds = new DataSet();
            adaptador.Fill(ds, "Persona");

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.actualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellidos = textBox2.Text;
            comando = new SQLiteCommand($"INSERT INTO persona ('Nombre','Apellidos') VALUES ('{nombre}','{apellidos}');", conexion);
            comando.ExecuteNonQuery();

            this.actualizarLista();
        }

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
    }
}