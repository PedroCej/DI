namespace Themes.MisTemas;

public partial class Tema1 : ResourceDictionary
{
	public Tema1()
	{
		InitializeComponent();
	}

	public static void cambiarTamano(double tam)
	{
		Application.Current.Resources["tamanoLabel"] = 20+20 * tam;
	}
	public void cambiTamano(double tam)
	{

	}
}