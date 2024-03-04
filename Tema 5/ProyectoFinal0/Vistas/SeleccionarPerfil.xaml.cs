using Microsoft.Maui.Controls;

namespace ProyectoFinal0.Vistas;

public partial class SeleccionarPerfil : ContentPage
{
	public SeleccionarPerfil()
	{
		InitializeComponent();
	}

    public void agregarPerfil(string nombre, string foto)
    {
        ImageButton nuevoImageButton = new ImageButton
        {
            Source = foto, HeightRequest = 150, WidthRequest = 150, CornerRadius = 75, Aspect = Aspect.AspectFill
        };
        nuevoImageButton.Pressed += ImageButton_Pressed;

        // Creamos un segundo Label
        Label nuevoLabel = new Label
        {
            Text = nombre, HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(0, 10, 0, 0) 
        };

        VerticalStackLayout nuevoVerticalStackLayout = new VerticalStackLayout
        {
            Margin = new Thickness(20, 0, 0, 0)
        };
        nuevoVerticalStackLayout.Children.Add(nuevoImageButton);
        nuevoVerticalStackLayout.Children.Add(nuevoLabel);

        // Agregamos los nuevos elementos al VerticalStackLayout
        hlayoutPerfiles.Children.Insert(hlayoutPerfiles.Count - 1, nuevoVerticalStackLayout);
    }

    private void btnUsuarioInvitado_Pressed(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage());
    }

    private async void ImageButton_Pressed(object sender, EventArgs e)
    {
            await Navigation.PushAsync(new Login(this));

    }
}