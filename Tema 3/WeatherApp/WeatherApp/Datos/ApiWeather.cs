using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WeatherApp.Datos
{
    public class ApiWeather
    {
        private JsonDocument jsonC;
        private JsonDocument jsonF;
        public async Task<bool> LlenarJson(string lat, string lon)
        {
            string respuesta, temperatura;
            List<string> listaTemperaturas = new List<string>();

            var direccion = new Uri("https://api.openweathermap.org/data/2.5/weather");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                
                try
                {
                    string consulta = $"?lat={lat}&lon={lon}&appid=a30b0362119b428e887ab2c2fd5907cf&units=metric&lang=es";
                    using (var response = await httpClient.GetAsync(consulta))
                    {
                        respuesta = await response.Content.ReadAsStringAsync();
                        jsonC = JsonDocument.Parse(respuesta);
                    }

                    consulta = $"?lat={lat}&lon={lon}&appid=a30b0362119b428e887ab2c2fd5907cf&lang=es";
                    using (var response = await httpClient.GetAsync(consulta))
                    {
                        respuesta = await response.Content.ReadAsStringAsync();
                        jsonF = JsonDocument.Parse(respuesta);
                    }
                }
                catch(Exception ex)
                {
                    return false;
                    MessageBox.Show("Error al cargar el JSON");
                }
            }
            return true;
        }

        public string ObtenerDescription()
        {
            return jsonC.RootElement.GetProperty("weather")[0].GetProperty("description").ToString();
        }
        public string ObtenerNombreLocalidad()
        {
            return jsonC.RootElement.GetProperty("name").ToString();
        }
        public string ObtenerCelsius()
        {
            return jsonC.RootElement.GetProperty("main").GetProperty("temp").ToString();
        }
        public string ObtenerFarenheit()
        {
            return jsonF.RootElement.GetProperty("main").GetProperty("temp").ToString();
        }
        public string ObtenerCodeIcon()
        {
            return jsonC.RootElement.GetProperty("weather")[0].GetProperty("icon").ToString();
        }
        public async Task<BitmapImage> CrearBitmap(string uri)
        {
            BitmapImage bmi;
            bmi = new BitmapImage(new Uri(uri));
            return bmi;
        }
        public async Task<BitmapImage> ObtenerBitMap(string lat, string lon)
        {
            string uri, codeIcon;
            BitmapImage bmi;

            codeIcon = ObtenerCodeIcon();
                
            uri = $"https://openweathermap.org/img/wn/{codeIcon}@2x.png";
            bmi = await CrearBitmap(uri) ;
            return bmi;
        }
    }
}
