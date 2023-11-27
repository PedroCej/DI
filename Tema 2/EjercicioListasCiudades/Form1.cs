using MySql.Data.MySqlClient;
using System.Data;

namespace EjercicioListasCiudades
{
    public partial class Form1 : Form
    {

        /*Cambiar el listbox para que devuelva paises y al pulsar doble click en uno salgan datos de todas las ciudades de ese pais*/

        /*Usar un DataSet para meter dos tablas en el mismo:
            - En un DataGrid añadir ciudades o paises dependiendo de lo que pulses
            - Pulsar un boton para guardar dos tablas en el DataSet
            - Probar a pasar un DataView al dataSource del datagrid
         */

        BBDD miBaseDatos;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {
            miBaseDatos = new BBDD(txtUser.Text, txtPasswd.Text, txtServer.Text, txtPort.Text);
            //miBaseDatos.Conectar();

            List<Ciudad> listaCiudades = miBaseDatos.ObtenerCiudades();
            foreach (Ciudad ciudad in listaCiudades) // se puede poner miBaseDatos.ObtenerCiudades(); directamente 
            {
                listBox1.Items.Add(ciudad);
            }
            // listBox1.DataSource = miBaseDatos.ObtenerCiudades();

            List<Pais> listaPaises = miBaseDatos.obtenerPaises();
            foreach (Pais pais in listaPaises)
            {
                listBox2.Items.Add(pais);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string codigoPais = miBaseDatos.ObtenerCiudades()[listBox1.SelectedIndex].CountryCode;
            Pais pais = miBaseDatos.obtenerPais(codigoPais);

            if (dataGridView1.Rows.Count < 1)
            {
                dataGridView1.Columns.Add("Code", "Code");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Continent", "Continent");
                dataGridView1.Columns.Add("SurfaceArea", "SurfaceArea");
                dataGridView1.Columns.Add("Population", "Population");
                dataGridView1.Columns.Add("lifeExpectancy", "lifeExpectancy");
            }
            dataGridView1.Rows.Add(pais.Code, pais.Name, pais.Continent, pais.SurfaceArea, pais.Population, pais.lifeExpectancy);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string codigoPais = miBaseDatos.obtenerPaises()[listBox2.SelectedIndex].Code;
            List<Ciudad> listaCiudades = miBaseDatos.ObtenerCiudades(codigoPais);

            if (dataGridView2.Rows.Count < 1)
            {
                dataGridView2.Columns.Add("ID", "ID");
                dataGridView2.Columns.Add("Name", "Name");
                dataGridView2.Columns.Add("CountryCode", "CountryCode");
                dataGridView2.Columns.Add("Population", "Population");
            }

            dataGridView2.Rows.Clear();
            foreach(Ciudad ciudad in listaCiudades)
            {
                dataGridView2.Rows.Add(ciudad.ID, ciudad.Nombre, ciudad.CountryCode, ciudad.Poblacion);
            }


        }
    }
}