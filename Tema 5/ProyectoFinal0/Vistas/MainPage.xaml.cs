using ProyectoFinal0.Servicios;

namespace ProyectoFinal0.Vistas;

public partial class MainPage : ContentPage
{
	DisneyAPI disneyAPI;
	public MainPage()
	{
		InitializeComponent();
		disneyAPI = new DisneyAPI();
	}

    private async void Button_Pressed(object sender, EventArgs e)
    {
		await disneyAPI.LlenarJsonPersonajes(1);
		lbl.Text=disneyAPI.ObtenerNombre();
    }
}