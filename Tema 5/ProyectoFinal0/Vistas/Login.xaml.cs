
using ProyectoFinal0.Datos;

namespace ProyectoFinal0.Vistas;


public partial class Login : ContentPage
{
    BBDD miBBDD = new BBDD();
    string fotoElegida = "invitado.png";
    SeleccionarPerfil paginaSeleccionarPerfil;
    /// <summary>
    /// Pagina crear perfiles, registro
    /// </summary>
    /// <param name="paginaSeleccionarPerfil">Objeto pagina seleccion perfil para añadir el perfil que crearemos</param>
    public Login(SeleccionarPerfil paginaSeleccionarPerfil)
    {
        InitializeComponent();
        this.paginaSeleccionarPerfil = paginaSeleccionarPerfil;
        SemanticScreenReader.Default.Announce("pagina login");
    }


    /// <summary>
    /// Volver a la pagina de seleccionar perfiles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancelar_Pressed(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
        SemanticScreenReader.Default.Announce("saliendo");
    }

    /// <summary>
    /// Selecciona la foto que quieres, dejando las otras en segundo plano
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void elegirFoto_Pressed(object sender, EventArgs e)
    {
        for (int i = 1; i <= 20; i++)
        {
            ImageButton b = (ImageButton) this.FindByName<ImageButton>($"img{i}");
            b.Opacity = 0.5;
        }

        if (sender is ImageButton imageButton)
        { 
            imageButton.Opacity = 1;
            if (imageButton.Source is FileImageSource fileImageSource)
            {
                fotoElegida = Path.GetFileName(fileImageSource.File);
            }
        }
    }

    /// <summary>
    /// Si todos los parametros son correctos crea el usuario y te devuelve a la pagina de perfiles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnConfirmar_Pressed(object sender, EventArgs e)
    {
        try
        {
             if (txtPass.Text == txtPass2.Text && txtUser.Text.ToString()!="")
            {
                if (miBBDD.RegisterTry(txtUser.Text) == false )
                {
                    miBBDD.CrearUsuario(txtUser.Text, txtPass.Text, fotoElegida);
                
                
                    paginaSeleccionarPerfil.agregarPerfil(txtUser.Text, fotoElegida);
                    Navigation.PopModalAsync();
                }
                else
                {
                    DisplayAlert("Error", $"El nombre de usuario {txtUser.Text} ya está en uso", "Aceptar");
                }
            }
            else
            {
                DisplayAlert("Error", "Las contraseñas deben coincidir", "Aceptar");
            }
        }catch(Exception ex)
        {
            DisplayAlert("Ha habiado un error", "No has puesto el nombre de usuario", "Ok");
        }
        
        
        
    }
    /// <summary>
    /// Menu flyout borrar contenido
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        txtUser.Text = "";
    }
}

