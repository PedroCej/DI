namespace MyMauiApp;

public partial class ActivityControlsDemo : ContentPage
{
	double cont = 0.0;
	public ActivityControlsDemo()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (actividad.Progress < 1)
		{
			actividad.Progress += 0.05;
		}
	}
}