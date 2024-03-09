using ProyectoFinal0.Datos;
using System.Data;
using System.Data.Entity.Core.Mapping;

namespace ProyectoFinal0.Vistas;

public partial class Admin : ContentPage
{
	BBDD db = new BBDD();
	public Admin()
	{
		InitializeComponent();

		db.Conectar();
		listView.ItemsSource = db.getAllUsers();	
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		db.EliminarUser(listView.SelectedItem.ToString());
		listView.ItemsSource = null;
		listView.ItemsSource = db.getAllUsers();
    }

}