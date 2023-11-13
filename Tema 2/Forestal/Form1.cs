namespace Forestal
{
    public partial class Form1 : Form
    {

        private List<Forestal> listaForestales = new List<Forestal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listaForestales.Add(new Forestal("Prueba1", "Prueba1", "Prueba1", "Prueba1"));
            listaForestales.Add(new Forestal("Prueba2", "Prueba2", "Prueba2", "Prueba2"));
            listBox1.DataSource = listaForestales;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay "+ listaForestales.Count + " forestales");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaForestales.RemoveAt(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = listaForestales;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this, listBox1.SelectedIndex);
            this.Hide();
            form3.ShowDialog();
        }

        public void añadirLista(string a, string b, string c, string d)
        {
            listaForestales.Add(new Forestal(a, b, c, d));
            listBox1.DataSource = null;
            listBox1.DataSource = listaForestales;
        }

        public Forestal consultarLista(int pos)
        {
            return listaForestales.ElementAt(pos);
        }

    }
}