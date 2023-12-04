namespace ExamenTema2A
{
    public partial class Form1 : Form
    {
        private List<Persona> personaList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personaList = new List<Persona>();
        }

        private void ToolStripMenuItemInsertar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public void InsertaPersona(Persona persona)
        {
            personaList.Add(persona);
        }

        private void ToolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(personaList);
            form4.ShowDialog();
        }

        private void ToolStripMenuItemMostrar_Click(object sender, EventArgs e)
        {
            foreach(Persona persona in personaList)
            {
                Form3 form3 = new Form3(persona.Nombre, persona.Apellido1, persona.Apellido2, persona.Telefono);
            }
        }
    }
}