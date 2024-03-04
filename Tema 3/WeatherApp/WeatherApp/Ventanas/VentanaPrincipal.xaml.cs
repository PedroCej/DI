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

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        ApiWeather miWeather;
        public VentanaPrincipal()
        {
            InitializeComponent();
            ciudadesControlUsuario.nuevoEvento += MiEventoHandler;
        }
        public async void MiEventoHandler()
        {
            miWeather = new ApiWeather();
            bool respuestaC, respuestaF;

            if(rbCelsius.IsChecked == true)
            {
                respuestaC = await miWeather.LlenarJson(ciudadesControlUsuario.ObtenerLat(), ciudadesControlUsuario.ObtenerLon());
                txtCiudad.Text = ciudadesControlUsuario.txtCiudadBuscar.Text;
                txtCiudad.Text = miWeather.ObtenerNombreLocalidad();
                txtTemperatura.Text = miWeather.ObtenerCelsius();
                txtTemperatura.Text += " ºC";
                txtTemperatura.Text += "\n";
                txtTemperatura.Text += miWeather.ObtenerDescription();
                imagenBitmap.Source = await miWeather.ObtenerBitMap(ciudadesControlUsuario.ObtenerLat(), ciudadesControlUsuario.ObtenerLon());
            }
            else
            {
                respuestaF = await miWeather.LlenarJson(ciudadesControlUsuario.ObtenerLat(), ciudadesControlUsuario.ObtenerLon());
                txtCiudad.Text = ciudadesControlUsuario.txtCiudadBuscar.Text;
                txtCiudad.Text = miWeather.ObtenerNombreLocalidad();
                txtTemperatura.Text = miWeather.ObtenerFarenheit();
                txtTemperatura.Text += " F";
                txtTemperatura.Text += "\n";
                txtTemperatura.Text += miWeather.ObtenerDescription();
                imagenBitmap.Source = await miWeather.ObtenerBitMap(ciudadesControlUsuario.ObtenerLat(), ciudadesControlUsuario.ObtenerLon());
            }
        }
        
        private void rbFarenheit_Click(object sender, RoutedEventArgs e)
        {
            
            txtTemperatura.Text = miWeather.ObtenerFarenheit();
            txtTemperatura.Text += " F";
            txtTemperatura.Text += "\n";
            txtTemperatura.Text += miWeather.ObtenerDescription();
            
        }

        private void rbCelsius_Click(object sender, RoutedEventArgs e)
        {
            
            txtTemperatura.Text = miWeather.ObtenerCelsius();
            txtTemperatura.Text += " ºC";
            txtTemperatura.Text += "\n";
            txtTemperatura.Text += miWeather.ObtenerDescription();
            
        }
        
    }
}
