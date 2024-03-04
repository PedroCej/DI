using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Datos;

namespace WeatherApp.ControlesUsuario
{
    /// <summary>
    /// Lógica de interacción para Busqueda.xaml
    /// </summary>
    public partial class Busqueda : UserControl
    {
        public delegate void MiEvento();
        public event MiEvento nuevoEvento;

        private ApiBingMap miApiBingMap;

        public Busqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            LlenarListBox();
        }
        private async void LlenarListBox()
        {
            lstCiudadesEncontradas.ItemsSource = null;
            lstCiudadesEncontradas.Items.Clear();
            miApiBingMap = new ApiBingMap();
            lstCiudadesEncontradas.ItemsSource = await miApiBingMap.ObtenerListaCiudades(txtCiudadBuscar.Text);
        }
        
        private async void lstCiudadesEncontradas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(lstCiudadesEncontradas.Items.Count > 0)
            {
                if(nuevoEvento != null)
                {
                    nuevoEvento();
                }
            }
        }
        public string ObtenerLat()
        {
            return miApiBingMap.ObtenerLatitud(lstCiudadesEncontradas.SelectedIndex);
        }
        public string ObtenerLon()
        {
            return miApiBingMap.ObtenerLongitud(lstCiudadesEncontradas.SelectedIndex);
        }
    }
}
