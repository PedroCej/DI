namespace ProyectoFinal0.Vistas;

public partial class AcercaDe : ContentPage
{
	/// <summary>
	/// Pagina Acerca De
	/// </summary>
	public AcercaDe()
	{
		InitializeComponent();
        SemanticScreenReader.Default.Announce("Estas en Acerca De");

    }
}