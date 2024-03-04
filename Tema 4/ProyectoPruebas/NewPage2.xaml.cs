namespace ProyectoPruebas;

public partial class NewPage2 : ContentPage
{

    public static String sed
    private AppShell original;
    
    public NewPage2()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NewPage2());

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();

    }
}