namespace ProyectoFinal0;

using Microsoft.Maui.Controls;
using ProyectoFinal0.Datos;

public partial class AppShell_Inicio : Shell
{
    BBDD bd = new BBDD();
    public string user="Invitado";
    public AppShell_Inicio()
    {
        InitializeComponent();
        Application.Current.Resources["user"] = user;
        
        if (bd.EsAdmin(user))
        {
            DisplayAlert("Bievenido, Admin", "", "Comenzar");
            itemAdmin.IsEnabled = true;
            itemAdmin.IsVisible = false;
        }
        else
        {
            itemAdmin.IsEnabled = false;
            itemAdmin.IsVisible = false;
        }

    }
    public AppShell_Inicio(string user)
    {
        InitializeComponent();
        this.user = user;   
        Application.Current.Resources["user"] = user;
        
    }
}


