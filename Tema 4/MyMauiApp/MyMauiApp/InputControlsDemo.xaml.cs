namespace MyMauiApp;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CheckBox miCheckbox = sender as CheckBox;
        bool estado = miCheckbox.IsChecked;
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {

        sliderLabel.Text = ((int)slider.Value).ToString(); // e.newValue.toString();
    }

    private void fecha_DateSelected(object sender, DateChangedEventArgs e)
    {
        DisplayAlert("Fecha", $"Has seleccionado {fecha.Date.ToString()}", "Salir");

    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {

    }
}