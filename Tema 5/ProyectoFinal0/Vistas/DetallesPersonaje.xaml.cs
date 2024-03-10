using ProyectoFinal0.Datos;
using ProyectoFinal0.Servicios;

namespace ProyectoFinal0.Vistas;

public partial class DetallesPersonaje : ContentPage
{
	int id;
	DisneyAPI disneyAPI;
    BBDD db = new BBDD();
	public DetallesPersonaje(DisneyAPI api,int id)
	{
		InitializeComponent();
		this.id = id;
		disneyAPI = api;
		
		llenarPagina();
        if (AppShell_Inicio.tipoUser == 1)
        {
            btnFav.IsVisible = false;
        }
        SemanticScreenReader.Default.Announce("Estas viendo detalles de " + disneyAPI.getNombre());
    }

	private async void llenarPagina()
	{
        await disneyAPI.llenarJsonUnPersonaje(id);
        try
        {
            
            llenarPeliculas();
            llenarCortos();
            llenarSeries();
            llenarJuegos();
            llenarAmigos();
            llenarEnemigos();
            lblNombre.Text = disneyAPI.getNombre();
            imagenPersonaje.Source = disneyAPI.getImagen();



        }
        catch(Exception e)
        {
            DisplayAlert("Algo salio mal","Algunas funciones podrían fallar","Ok");
            SemanticScreenReader.Default.Announce("error en esta pagina");
        }
        
    }

	private void llenarPeliculas()
	{
        List<string> peliculas = disneyAPI.getPeliculas();
        foreach (string p in peliculas)
        {
            descPeliculas.Text += " - " + p + "\n";
        }
        if (peliculas.Count == 0)
            lblPeliculas.Text = "";
    }
    private void llenarCortos()
    {
        List<string> lista = disneyAPI.getCortos();
        foreach (string p in lista)
        {
            descCortos.Text += " - " + p + "\n";
        }
        if (lista.Count == 0)
            lblCortos.Text = "";
    }
    private void llenarSeries()
    {
        List<string> lista = disneyAPI.getSeries();
        foreach (string p in lista)
        {
            descSeries.Text += " - " + p + "\n";
        }
        if (lista.Count == 0)
            lblSeries.Text = "";
    }
    private void llenarJuegos()
    {
        List<string> lista = disneyAPI.getJuegos();
        foreach (string p in lista)
        {
            descJuegos.Text += " - " + p + "\n";
        }
        if (lista.Count == 0)
            lblJuegos.Text = "";
    }
    private void llenarAmigos()
    {
        List<string> lista = disneyAPI.getAmigos();
        foreach (string p in lista)
        {
            descAmigos.Text += " - " + p + "\n";
        }
        if (lista.Count == 0)
            lblAmigos.Text = "";
    }
    private void llenarEnemigos()
    {
        List<string> lista = disneyAPI.getEnemigos();
        foreach (string p in lista)
        {
            descEnemigos.Text += " - " + p + "\n";
        }
        if (lista.Count == 0)
            lblEnemigos.Text = "";
    }

    private void btnFav_Clicked(object sender, EventArgs e)
    {
        string user = Application.Current.Resources["user"].ToString();
        string nombre = lblNombre.Text.ToString();
        DisplayAlert("Personaje guardado",$"El usuario {user} ha guardado a {nombre}","Aceptar");
        db.guardarPersonaje(id, user, nombre, disneyAPI.getImagen());
        btnFav.Opacity = 1;
        SemanticScreenReader.Default.Announce("Añadido a favoritos");
    }
}