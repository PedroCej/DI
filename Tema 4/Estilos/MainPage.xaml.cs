using Microsoft.Maui.Controls;

namespace Estilos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            lbl1.TextColor = Colors.White;
            lbl2.TextColor = Colors.White;
            lbl3.TextColor = Colors.White;

            this.Resources["auxiliar"] = this.Resources["estiloEtiqueta1"];

            this.Resources["estiloEtiqueta1"] = this.Resources["estiloEtiqueta2"];

            

        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Resources["auxiliar"] = this.Resources["modoOscuro"];

        }
    }

}
