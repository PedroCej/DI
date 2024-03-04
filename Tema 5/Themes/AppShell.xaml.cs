using Themes.Vistas;

namespace Themes
{
    public partial class AppShell : Shell
    {
        private personalizarTemas personalizarMisTemas;
        public AppShell()
        {
            InitializeComponent();
        }

        private async void botonTema_Clicked(object sender, EventArgs e)
        {
            if(personalizarMisTemas == null)
            {
                personalizarMisTemas = new personalizarTemas();
            }
            await Navigation.PushAsync(personalizarMisTemas);
        }
    }
}
