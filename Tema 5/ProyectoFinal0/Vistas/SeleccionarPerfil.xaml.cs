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

    
    /// <summary>
    /// Pulsar un perfil que no sea invitado
    /// </summary>
    /// <param name="sender">Boton de cualquier perfil</param>
    /// <param name="e"></param>
    private async void ImageButton_Pressed(object sender, EventArgs e)
    {
        ImageButton botonPresionado = sender as ImageButton;
        string pass = await DisplayPromptAsync("Introduce contraseña","");
        string user = botonPresionado.AutomationId.ToString();
        if (miBBDD.LoginTry(user, pass)) // si usuairo y contraseña extan registrados
        {
            Application.Current.MainPage = new AppShell_Inicio(user);  // carga el shell Inicio de la aplicacion
        }
        else
        {
            if (pass != null)
            {
                await DisplayAlert("Error", "La contraseña es incorrecta", "Aceptar");
            }
        }
    }

    /// <summary>
    /// Boton para ir a la pagina de registro, crear un perfil
    /// </summary>
    /// <param name="sender">ImageButton</param>
    /// <param name="e"></param>
    private void ImageButton_Pressed_1(object sender, EventArgs e)
    {
        if(miBBDD.getNumUsers()<6)
        {
            Navigation.PushModalAsync(new Login(this));
        }
        else
        {
            DisplayAlert("No puedes crear mas usuarios","El limite de usuarios es 6, si quieres añadir uno mas contacta con el administrador de la cuenta.","Aceptar");
        }
        
    }

    
    /// <summary>
    /// Evento de pulsar el boton para editar los usuarios
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string pass = await DisplayPromptAsync("Introduce contraseña de administrador", "");
        if (miBBDD.LoginTry("admin", pass))
        {
            await Navigation.PushAsync(new Admin());
        }
        else
        {
            DisplayAlert("Contraseña incorrecta", "", "Volver");
        }
    }
}