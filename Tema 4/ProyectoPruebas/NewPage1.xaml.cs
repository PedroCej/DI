namespace ProyectoPruebas;

public partial class NewPage1 : ContentPage
{
    private NewPage2 paginaLogin;
	private BBDD.BBDD miBBDD;
	private AppShell appShellOriginal;
	public NewPage1()
	{
		InitializeComponent();
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		miBBDD = new BBDD.BBDD();
		if(paginaLogin == null) 
			paginaLogin = new NewPage2(this);
		Navigation.PushModalAsync(paginaLogin);	
		 
    }

 
}