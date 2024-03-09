using ProyectoFinal0.Servicios;

namespace ProyectoFinal0.Vistas;

public partial class Inicio : ContentPage
{
	DisneyAPI api;
	private int pagina = 148;

	public Inicio()
	{
		InitializeComponent();
		api = new DisneyAPI();
        try
        {
            llenarGrid(pagina);
        }catch(Exception ex)
        {
            DisplayAlert("", "", "");
        }
		
	}

    private async void btnSiguiente_Clicked(object sender, EventArgs e)
    {
        if(pagina<api.getNumeroPaginas())
        {
            pagina++;
		    llenarGrid(pagina);
            await miScroll.ScrollToAsync(-400, 20, true);
        }
        else
        {
            bool answer = await DisplayAlert("No hay mas paginas", "¿Quieres volver al inicio del buscador?", "Si, volver", "No");
            if(answer)
            {
                pagina = 1;
                llenarGrid(pagina);
                await miScroll.ScrollToAsync(-400, 20, true);
            }
        }

    }
    private async void btnAnterior_Clicked(object sender, EventArgs e)
    {
        if (pagina > 1)
        {
            pagina--;
            llenarGrid(pagina);
            await miScroll.ScrollToAsync(-400, 20, true);
        }
        else
        {
            bool answer = await DisplayAlert("No hay paginas anteriores", "¿Quieres ir al final del buscador?", "Si", "No");
            if (answer)
            {
                pagina = api.getNumeroPaginas();
                llenarGrid(pagina);
                await miScroll.ScrollToAsync(-400, 20, true);
            }
        }
        
    }

    /// <summary>
    /// Rellena el grid que contiene imagenes y nombres de personajes
    /// </summary>
    /// <param name="pagina"></param>
	private async void llenarGrid(int pagina)
	{       
        await api.LlenarJsonPersonajes(pagina);        
        lblPagina.Text = $"{pagina}/{api.getNumeroPaginas().ToString()}";
        gridObjetos.Children.Clear();
		List<string> listaNombres = api.ObtenerListaNombres();
        List<string> listaFotos = api.ObtenerListaFotos();
        int element = 0;
        
		for(int i = 0; i < 10; i++)
		{
            for (int j = 0; j < 5; j++)
            {
                if (element < api.getCantidadPersonajesPagina())
                {
                    ImageButton imageButtonPersonaje = new ImageButton
                    {
                        Source = listaFotos.ElementAt(element).ToString(),
                        HeightRequest = 200,
                        CornerRadius = 20,
                        Aspect = Aspect.Fill,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        AutomationId = api.getId_pos(element).ToString()// Le pongo como id el id que tiene en el json
                    };
                    imageButtonPersonaje.Pressed += btnPersonaje_Clicked;

                    Label labelNombre = new Label
                    {
                        Text = listaNombres.ElementAt(element).ToString(),
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 10, 0, 0)
                    };

                    element++;

                    //Cada casilla del grid contiene un verticalStack con imagen y nombre
                    VerticalStackLayout nuevoVerticalStackLayout = new VerticalStackLayout
                    {
                        Margin = new Thickness(10, 0, 0, 10)
                    };
                    nuevoVerticalStackLayout.Children.Add(imageButtonPersonaje);
                    nuevoVerticalStackLayout.Children.Add(labelNombre);

                    Grid.SetRow(nuevoVerticalStackLayout, i);
                    Grid.SetColumn(nuevoVerticalStackLayout, j);
                    gridObjetos.Add(nuevoVerticalStackLayout);

                } // if
            }//for2
        }//for1
	} // llenar grid

    private async void llenarGrid(string busqueda)
    {
        await api.LlenarJsonPersonajes(busqueda);
        lblPagina.Text = $"{pagina}/{api.getNumeroPaginas().ToString()}";
        gridObjetos.Children.Clear();
        List<string> listaNombres = api.ObtenerListaNombres();
        List<string> listaFotos = api.ObtenerListaFotos();
        int element = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (element < api.getCantidadPersonajesPagina())
                {
                    ImageButton imageButtonPersonaje = new ImageButton
                    {
                        Source = listaFotos.ElementAt(element).ToString(),
                        HeightRequest = 200,
                        CornerRadius = 20,
                        Aspect = Aspect.Fill,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        AutomationId = api.getId_pos(element).ToString()// Le pongo como id el id que tiene en el json
                    };
                    imageButtonPersonaje.Pressed += btnPersonaje_Clicked;

                    Label labelNombre = new Label
                    {
                        Text = listaNombres.ElementAt(element).ToString(),
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 10, 0, 0)
                    };

                    element++;

                    //Cada casilla del grid contiene un verticalStack con imagen y nombre
                    VerticalStackLayout nuevoVerticalStackLayout = new VerticalStackLayout
                    {
                        Margin = new Thickness(10, 0, 0, 10)
                    };
                    nuevoVerticalStackLayout.Children.Add(imageButtonPersonaje);
                    nuevoVerticalStackLayout.Children.Add(labelNombre);

                    Grid.SetRow(nuevoVerticalStackLayout, i);
                    Grid.SetColumn(nuevoVerticalStackLayout, j);
                    gridObjetos.Add(nuevoVerticalStackLayout);

                } // if
            }//for2
        }//for1
    } // llenar grid con string

    private void btnPersonaje_Clicked(object sender, EventArgs e)
    {
        ImageButton botonPresionado = sender as ImageButton;
        string id = botonPresionado.AutomationId;
        Navigation.PushAsync(new DetallesPersonaje(api, Int32.Parse(botonPresionado.AutomationId)));

        
    }

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = sender as SearchBar;
        llenarGrid(searchBar.Text.TrimEnd().ToString());
        

    }
}//program


