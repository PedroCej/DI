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

namespace Dataset2
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conexion != null)
                conexion.Close();
            try
            {
                conexion = new MySqlConnection("server=localhost;port=3306;userid =root; password =root; database =ingenieros; Allow Zero Datetime = True;CHARSET = latin1");
                comando = new MySqlCommand("SELECT * FROM forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                ds = new DataSet();
                conexion.Open();
                adaptador.Fill(ds);
                conexion.Close();
                //LLenamos listBox1 con el nombre de las columnas de las tablas
                foreach (DataColumn col in ds.Tables[0].Columns)
                {
                    listBox1.Items.Add(col.ColumnName);
                }
                //Obtenemos el número de columnas
                label1.Text = "Numero de columnas: " + ds.Tables[0].Columns.Count.ToString();
                //Obtenemos el número de filas
                label2.Text = "Numero de filas: " + ds.Tables[0].Rows.Count.ToString();
                //Obtenemos de la primera fila el primer campo 1ª forma
                //Se crea un dataRow al que se le asigna la primera fila, luego de esa fila obtenemos el primer campo

                DataRow fila = ds.Tables[0].Rows[0];
                textBox1.Text = fila[0].ToString();
                //Obtenemos de la primera fila el primer campo 2ª forma
                textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " +
                ex.Message, "Error al conectar",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}