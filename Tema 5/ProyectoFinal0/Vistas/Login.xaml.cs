
using ProyectoFinal0.Datos;

namespace ProyectoFinal0.Vistas;


public partial class Login : ContentPage
{
    BBDD miBBDD = new BBDD();
    string fotoElegida = "invitado.png";
    SeleccionarPerfil paginaSeleccionarPerfil;
    public Login(SeleccionarPerfil paginaSeleccionarPerfil)
    {
        InitializeComponent();
        this.paginaSeleccionarPerfil = paginaSeleccionarPerfil;
    }


    private void btnCancelar_Pressed(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

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

    private void btnConfirmar_Pressed(object sender, EventArgs e)
    {
        if (txtPass.Text == txtPass2.Text)
        {
            if (miBBDD.RegisterTry(txtUser.Text) == false)
            {
                miBBDD.CrearUsuario(txtUser.Text, txtPass.Text, fotoElegida);
                
                
                paginaSeleccionarPerfil.agregarPerfil(txtUser.Text, fotoElegida);
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Error", $"El nombre de usuario {txtUser.Text} ya est� en uso", "Aceptar");
            }
        }
        else
        {
            DisplayAlert("Error", "Las contrase�as deben coincidir", "Aceptar");
        }
        
        
    }
}

