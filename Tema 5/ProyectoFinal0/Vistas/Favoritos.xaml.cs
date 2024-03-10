using ProyectoFinal0.Datos;

namespace ProyectoFinal0.Vistas;

public partial class Favoritos : ContentPage
{
    BBDD db = new BBDD();
    private string user = Application.Current.Resources["user"].ToString();
    public Favoritos()
	{
		InitializeComponent();
        llenarGrid();
        SemanticScreenReader.Default.Announce("Estas en favoritos");
    }

    private async void llenarGrid()
    {
        gridObjetos.Children.Clear();
        List<string> listaNombres = db.getPersonajesGuardados(user);
        List<string> listaFotos = db.getFotosGuardadas(user);
        int element = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (element < db.getNumeroPersonajesGuardados(user))
                {
                    ImageButton imageButtonPersonaje = new ImageButton
                    {
                        Source = listaFotos.ElementAt(element).ToString(),
                        HeightRequest = 200,
                        CornerRadius = 20,
                        Aspect = Aspect.Fill,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        AutomationId = db.getIdGuardado(listaNombres.ElementAt(element).ToString())// Le pongo como id el id que tiene en el json
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

    private void btnPersonaje_Clicked(object? sender, EventArgs e)
    {
        ImageButton botonPresionado = sender as ImageButton;
        string id = botonPresionado.AutomationId;
        Navigation.PushAsync(new DetallesPersonaje(new Servicios.DisneyAPI(), Int32.Parse(botonPresionado.AutomationId)));
        SemanticScreenReader.Default.Announce("entrando al personaje");

    }
}