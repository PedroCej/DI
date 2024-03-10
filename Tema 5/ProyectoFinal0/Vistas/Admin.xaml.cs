using ProyectoFinal0.Datos;
using System.Data;
using System.Data.Entity.Core.Mapping;

namespace ProyectoFinal0.Vistas;

public partial class Admin : ContentPage
{
	BBDD db = new BBDD();
	/// <summary>
	/// Pagina de admin
	/// </summary>
	public Admin()
	{
		InitializeComponent();

		db.Conectar();
		listView.ItemsSource = db.getAllUsers();
        SemanticScreenReader.Default.Announce("Pagina de admin");



    }

	/// <summary>
	/// Eliminar el usuario seleccionado en el listview
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			string user = listView.SelectedItem.ToString();
			if (user != "admin")
			{
				db.EliminarUser(user);
				listView.ItemsSource = null;
				listView.ItemsSource = db.getAllUsers();
                SemanticScreenReader.Default.Announce("Eliminaste un usuario");
            }
			else
			{
				DisplayAlert("No puedes eliminar al admin","","Ok");
			}
		}catch(Exception ex)
		{
			DisplayAlert("No has seleccionado ningun usuario", "", "Ok");
        }
		
        
    }

}