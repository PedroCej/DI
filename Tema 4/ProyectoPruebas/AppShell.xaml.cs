namespace ProyectoPruebas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public void cambiarTitulo(string titulo)
        {
            lblTitulo.Text = titulo;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
