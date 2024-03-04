using Microsoft.Maui.Controls;
using ProyectoFinal0.Datos;

namespace ProyectoFinal0.Vistas;

public partial class SeleccionarPerfil : ContentPage
{
    BBDD miBBDD;
    List<string> listaUsuarios;
    public int numUsuarios {  get; set; }
	public SeleccionarPerfil()
	{
		InitializeComponent();
        LlenarUsuarios();
        
	}

    //Rellenar la pagina con los usuarios que ya se hayan creado
    private void LlenarUsuarios()
    {
        miBBDD = new BBDD();
        miBBDD.Conectar();
        listaUsuarios = miBBDD.getUsuarios();
        for(int i=0; i < listaUsuarios.Count(); i++)
        {
            string usuario = listaUsuarios[i];
            agregarPerfil(usuario, miBBDD.getFoto(usuario));
        }
        numUsuarios = listaUsuarios.Count();
    }

    public void agregarPerfil(string usuario, string foto)
    {
        // Creamos el boton
        ImageButton nuevoImageButton = new ImageButton
        {
            Source = foto, HeightRequest = 150, WidthRequest = 150, CornerRadius = 75, Aspect = Aspect.AspectFill, AutomationId = usuario
        };
        nuevoImageButton.Pressed += ImageButton_Pressed;

        // Creamos el label
        Label nuevoLabel = new Label
        {
            Text = usuario, HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(0, 10, 0, 0) 
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
        Application.Current.MainPage = new AppShell_Inicio();
    }

    //Pulsar un perfil que no sea invitado
    private async void ImageButton_Pressed(object sender, EventArgs e)
    {
        string pass = await DisplayPromptAsync("Introduce contraseña","");
        ImageButton botonPresionado = sender as ImageButton;
        
        if (miBBDD.LoginTry(botonPresionado.AutomationId.ToString(), pass)) // si usuairo y contraseña extan registrados
        {
            Application.Current.MainPage = new AppShell_Inicio();  // carga el shell Inicio de la aplicacion
        }
        else
        {
            if (pass != null)
            {
                await DisplayAlert("Error", "La contraseña es incorrecta", "Aceptar");
            }
        }
    }

    //Boton añadir perfil
    private void ImageButton_Pressed_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login(this));
    }
}