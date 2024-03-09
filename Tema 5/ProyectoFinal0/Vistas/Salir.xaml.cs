namespace ProyectoFinal0.Vistas;

public partial class Salir : ContentPage
{
	public Salir()
	{
		InitializeComponent();
	}

    private void btnAceptar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell_Login();
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Gracias por quedarte","Esta bien eso","Ok");
    }
}