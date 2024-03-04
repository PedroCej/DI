using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;//Sin este using no se pueden crear objetos JSON
using System.Net.Http;
using System.Xml.Serialization;

namespace WeatherApp.Datos
{
    public class ApiBingMap
    {
        JsonDocument json;
       
        public async Task<List<String>> ObtenerListaCiudades(string ciudad)
        {
            string respuesta;
            List<string> listaCiudades = new List<string>();


            var direccion = new Uri("http://dev.virtualearth.net/REST/v1/Locations/");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                string consulta =  $"{ciudad}?maxResults=20&key=UBuKaEjHBNFLq3DKgsUY~jLI1__Q13_fKdHbZBp9AMw~AprNTJEZZ2fszbvROm0jC2s3KOBxPusV_6vDWU_Zbq9qTkZJEQnM6peNdIN-5uwL";
                using (var response = await httpClient.GetAsync(consulta))
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    json = JsonDocument.Parse(respuesta);
                    int numCiudades = json.RootElement.GetProperty("resourceSets")[0].GetProperty("resources").GetArrayLength();
                    for (int i = 0; i < numCiudades; i++)
                    {
                        listaCiudades.Add(json.RootElement.GetProperty("resourceSets")[0].GetProperty("resources")[i].GetProperty("name").ToString());
                    }
                }
            }
            return listaCiudades;
        }
        
        public string ObtenerLatitud(int posicion)
        {
           return json.RootElement.GetProperty("resourceSets")[0].GetProperty("resources")[posicion].GetProperty("point").GetProperty("coordinates")[0].ToString(); ;
        }

        public string ObtenerLongitud(int posicion)
        {
            return json.RootElement.GetProperty("resourceSets")[0].GetProperty("resources")[posicion].GetProperty("point").GetProperty("coordinates")[1].ToString();
        }
    }
}
