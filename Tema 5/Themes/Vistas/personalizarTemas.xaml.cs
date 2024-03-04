using Android.App;
using Themes.MisTemas;
using Themes.Resources.Idiomas;

namespace Themes.Vistas;
/// <summary>
/// Clase personalizarTemas que permite cambiar el tema de la aplicacion
/// </summary>
public partial class personalizarTemas : ContentPage
{
    /// <summary>
    /// Constructor de la clase, Por ejemplo un login lleva un param AppShell
    /// </summary>
    /// <param name="s">recibe como parametro el objeto AppShell de la aplicacion</param>
	public personalizarTemas()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		RadioButton miRadioButton = sender as RadioButton;
		if (miRadioButton.IsChecked)
		{
			ICollection<ResourceDictionary> miListaDiccionarios;
			miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
			miListaDiccionarios.Clear();
			if (miRadioButton.Value.ToString() == "0")
			{
				miListaDiccionarios.Add(new Tema1());
                SemanticScreenReader.Default.Announce("Has elegido el tema original, eso esta muy bien");
			}
            if (miRadioButton.Value.ToString() == "1")			
			{
                miListaDiccionarios.Add(new Tema2());
            }
            if (miRadioButton.Value.ToString() =="2")
			{
                miListaDiccionarios.Add(new Tema3());
            }
        }
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		Picker miPicker = sender as Picker;
        ICollection<ResourceDictionary> miListaDiccionarios;
        miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
        miListaDiccionarios.Clear();
        if (miPicker.SelectedIndex == 0)
		{
            miListaDiccionarios.Add(new espanol());
        }
        if (miPicker.SelectedIndex == 1)
        {
            miListaDiccionarios.Add(new ingles());
        }
        miListaDiccionarios.Add(new Tema1());
        miListaDiccionarios.["Tema1"].
        

    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double tam = e.NewValue;
        Tema1.cambiarTamano(tam);
    }
}