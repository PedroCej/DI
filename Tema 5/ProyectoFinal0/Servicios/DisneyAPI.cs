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

        public List<string> ObtenerListaNombres()
        {
            List<string> lista = new List<string>();
            int cantidad = json.RootElement.GetProperty("info").GetProperty("count").GetInt32();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(json.RootElement.GetProperty("data")[i].GetProperty("name").GetString());
            }
            return lista;
        }

        public string ObtenerNombre()
        {
            return json.RootElement.GetProperty("data")[0].GetProperty("name").ToString();
        }
    }
    
}
