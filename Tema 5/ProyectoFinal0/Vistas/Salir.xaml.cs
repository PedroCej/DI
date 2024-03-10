namespace ProyectoFinal0.Vistas;

public partial class Salir : ContentPage
{
    /// <summary>
    /// Pagina estas seguro de salir
    /// </summary>
	public Salir()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Salir de la app
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAceptar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell_Login();
    }

    /// <summary>
    /// Boton cancelar, no salir de la app
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Gracias por quedarte","Esta bien eso","Ok");
    }
}