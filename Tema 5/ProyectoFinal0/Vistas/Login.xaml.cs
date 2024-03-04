
using ProyectoFinal0.Datos;

namespace ProyectoFinal0.Vistas;


public partial class Login : ContentPage
{
    BBDD miBBDD = new BBDD();
    string fotoElegida = "img_invitado.png";
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
    {/*
        img1.Opacity = 0.5;
        img2.Opacity = 0.5;
        img3.Opacity = 0.5;
        img4.Opacity = 0.5;
        img5.Opacity = 0.5;
        img6.Opacity = 0.5;
        img7.Opacity = 0.5;
        img8.Opacity = 0.5;
        img9.Opacity = 0.5;
        img10.Opacity = 0.5;
        img11.Opacity = 0.5;
        img12.Opacity = 0.5;
        img13.Opacity = 0.5;
        img14.Opacity = 0.5;
        img15.Opacity = 0.5;
        img16.Opacity = 0.5;
        img17.Opacity = 0.5;
        img18.Opacity = 0.5;
        img19.Opacity = 0.5;
        img20.Opacity = 0.5;

        if (sender is ImageButton imageButton)
        
            imageButton.Opacity = 1;

        }*/
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
                DisplayAlert("Error", $"El nombre de usuario {txtUser.Text} ya está en uso", "Aceptar");
            }
        }
        else
        {
            DisplayAlert("Error", "Las contraseñas deben coincidir", "Aceptar");
        }
        
        
    }
}

