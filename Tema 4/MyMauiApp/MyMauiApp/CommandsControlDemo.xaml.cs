namespace MyMauiApp;

public partial class CommandsControlDemo : ContentPage
{
	private int cont = 0;
	public CommandsControlDemo()
	{
		InitializeComponent();
	}

    private void miBoton_Clicked(object sender, EventArgs e)
    {
		cont++;
		DisplayAlert("Botón", "Has pulsado el botón", "Salir");
		miLabel.Text = $"Has pulsado el boton {cont} veces";
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		RadioButton miRadio = (RadioButton)sender;
		if (miRadio.IsChecked)
		{
			DisplayAlert("Radio Botón", $"Has pulsado {miRadio.Content}", "Salir");
		}
    }

    private void barraBusqueda_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Buscador", $"Has buscado {barraBusqueda.Text}", "Salir");
    }
}