using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoFinal0.Servicios
{
    public class DisneyAPI
    {
        JsonDocument json;

        public DisneyAPI()
        {

        }

        public async Task<bool> LlenarJsonPersonajes(int pagina)
        {
            string respuesta;
            var direccion = new Uri("http://api.disneyapi.dev/character");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                try
                {
                    string consulta = $"?page={pagina}&pageSize=50";
                    using (var response = await httpClient.GetAsync(consulta))
                    {
                        respuesta = await response.Content.ReadAsStringAsync();
                        json = JsonDocument.Parse(respuesta);
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
        
        public string ObtenerNombre()
        {
            return json.RootElement.GetProperty("data")[0].GetProperty("name").ToString();
        }
    }
    
}
