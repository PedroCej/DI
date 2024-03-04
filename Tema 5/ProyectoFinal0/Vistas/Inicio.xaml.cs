using ProyectoFinal0.Servicios;

namespace ProyectoFinal0.Vistas;

public partial class Inicio : ContentPage
{
	DisneyAPI api;
	private int pagina = 1;
	public Inicio()
	{
		InitializeComponent();
		api = new DisneyAPI();
		llenarGrid(pagina);
	}

    private void btnSiguiente_Clicked(object sender, EventArgs e)
    {
		llenarGrid(pagina);
		pagina++;
    }



	private async void llenarGrid(int pagina)
	{
		await api.LlenarJsonPersonajes(pagina);
		gridObjetos.Children.Clear();
		List<string> lista = api.ObtenerListaNombres();
        int element = 0;
        
		for(int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				var label = new Label { Text = lista.ElementAt(element).ToString() };
				element++;
                Grid.SetRow(label, i);
                Grid.SetColumn(label, j);
                gridObjetos.Add(label);

            }
		}
		
		
	}
}