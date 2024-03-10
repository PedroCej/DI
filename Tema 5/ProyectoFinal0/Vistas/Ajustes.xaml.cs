namespace ProyectoFinal0.Vistas;

using Resources.MisTemas;
using Resources.Idiomas;

public partial class Ajustes : ContentPage
{
	public Ajustes()
	{
		InitializeComponent();
        ICollection<ResourceDictionary> miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton miRadioButton = sender as RadioButton;
        if (miRadioButton.IsChecked)
        {
            ICollection<ResourceDictionary> miListaDiccionarios;
            miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
            if (miRadioButton.Value.ToString() == "0")
            {
                miListaDiccionarios.Add(new TemaDefault());
                SemanticScreenReader.Default.Announce("tema original");
            }
            if (miRadioButton.Value.ToString() == "1")
            {
                miListaDiccionarios.Add(new TemaClaro());
                SemanticScreenReader.Default.Announce("tema claro");
            }
            if (miRadioButton.Value.ToString() == "2")
            {
                miListaDiccionarios.Add(new TemaOscuro());
                SemanticScreenReader.Default.Announce("tema oscuro");
            }
        }
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        Picker miPicker = sender as Picker;
        ICollection<ResourceDictionary> miListaDiccionarios;
        miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
        
        if (miPicker.SelectedIndex == 0)
        {
            miListaDiccionarios.Add(new espanol());
            SemanticScreenReader.Default.Announce("español");
        }
        if (miPicker.SelectedIndex == 1)
        {
            miListaDiccionarios.Add(new ingles());
            SemanticScreenReader.Default.Announce("ingles");
        }
       



    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Slider slider = sender as Slider;
        App.Current.Resources["tamanoLetra"] = 15 * slider.Value;
        App.Current.Resources["tamanoLetraTitulo"] = 50 * slider.Value;
        App.Current.Resources["tamanoLetraTitulo2"] = 25 * slider.Value;
        SemanticScreenReader.Default.Announce("cambiando tamaño");

    }
}