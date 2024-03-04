namespace MyMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Has clickado {count} vez";
            else if (count == 33)
                CounterBtn.Text = $"Has clicado {count} veces... \n COMO??!! REPITEME ESE NUMERIN";
            else
                CounterBtn.Text = $"Has clickado {count} veces";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
