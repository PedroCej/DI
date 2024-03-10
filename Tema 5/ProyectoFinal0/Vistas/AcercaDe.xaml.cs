namespace ProyectoFinal0.Vistas;

public partial class AcercaDe : ContentPage
{
	public AcercaDe()
	{
		InitializeComponent();
        SemanticScreenReader.Default.Announce("Estas en Acerca De");

    }
}