﻿using System;
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
        JsonDocument jsonPersonaje;

        public DisneyAPI()
        {

        }

        /// <summary>
        /// Este metodo se utiliza para llenar el json con la url base de la API, debes especificar la pagina, en cada pagina puedes consultar cuantas existen
        /// </summary>
        /// <param name="pagina">Pagina de la API que quieres consultar</param>
        /// <returns>bool true => JSON lleno
        ///         bool false => error al llenar json</returns>
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
        /// <summary>
        /// llenar json cuando usamos la barra de navegacion
        /// </summary>
        /// <param name="buscar">parametro de busqueda</param>
        /// <returns>task bool si se completa = true</returns>
        public async Task<bool> LlenarJsonPersonajes(string buscar)
        {
            string respuesta;
            var direccion = new Uri("http://api.disneyapi.dev/character");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                try
                {
                    string consulta = $"?name={buscar}";
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
        /// <summary>
        /// Llenar el json secundario para un personaje
        /// </summary>
        /// <param name="id">id del personaje</param>
        /// <returns>task bool si se completa = true</returns>
        public async Task<bool> llenarJsonUnPersonaje(int id)
        {
            string respuesta;
            var direccion = new Uri($"http://api.disneyapi.dev/character/{id}");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                try
                {
                    string consulta = $"";
                    using (var response = await httpClient.GetAsync(consulta))
                    {
                        respuesta = await response.Content.ReadAsStringAsync();
                        jsonPersonaje = JsonDocument.Parse(respuesta);
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        //
        //  METODOS JSON PRINCIPAL
        //

        /// <summary>
        /// Lista de nombres del json
        /// </summary>
        /// <returns>List of strings</returns>
        public List<string> ObtenerListaNombres()
        {
            List<string> lista = new List<string>();
            int cantidad = getCantidadPersonajesPagina();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(json.RootElement.GetProperty("data")[i].GetProperty("name").GetString());
            }
            return lista;
        }

        /// <summary>
        /// Lista de fotos en una pagina del json, se relacionan con el nombre por la posicion en la lista
        /// </summary>
        /// <returns>List de strings</returns>
        public List<string> ObtenerListaFotos()
        {
            List<string> lista = new List<string>();
            int cantidad = json.RootElement.GetProperty("info").GetProperty("count").GetInt32();
            for (int i = 0; i < cantidad; i++)
            {
                try
                {
                    lista.Add(json.RootElement.GetProperty("data")[i].GetProperty("imageUrl").GetString());
                }catch(Exception ex)
                {
                    lista.Add("no_image.png");
                }
                
            }
            return lista;
        }


        //
        //  METODOS JSON SECUNDARIO (un personaje)
        //

        /// <summary>
        /// Peliculas del personaje
        /// </summary>
        /// <returns>List de strings</returns>
        public List<string> getPeliculas()
        {
            List<string> lista = new List<string>();

            int cantidad = jsonPersonaje.RootElement.GetProperty("data").GetProperty("films").GetArrayLength();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(jsonPersonaje.RootElement.GetProperty("data").GetProperty("films")[i].ToString());
            }
            return lista;
        }

        /// <summary>
        /// Lista de cortos del personaje (json)
        /// </summary>
        /// <returns>Lisa de strings</returns>
        public List<string> getCortos()
        {
            List<string> lista = new List<string>();

            int cantidad = jsonPersonaje.RootElement.GetProperty("data").GetProperty("shortFilms").GetArrayLength();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(jsonPersonaje.RootElement.GetProperty("data").GetProperty("shortFilms")[i].ToString());
            }
            return lista;
        }
        /// <summary>
        /// Consulta en el json las series de un personaje
        /// </summary>
        /// <returns>List de strings</returns>
        public List<string> getSeries()
        {
            List<string> lista = new List<string>();

            int cantidad = jsonPersonaje.RootElement.GetProperty("data").GetProperty("tvShows").GetArrayLength();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(jsonPersonaje.RootElement.GetProperty("data").GetProperty("tvShows")[i].ToString());
            }
            return lista;
        }

        /// <summary>
        /// Consulta en el json para tener una lista de juegos
        /// </summary>
        /// <returns>Lista de strings</returns>
        public List<string> getJuegos()
        {
            List<string> lista = new List<string>();

            int cantidad = jsonPersonaje.RootElement.GetProperty("data").GetProperty("videoGames").GetArrayLength();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(jsonPersonaje.RootElement.GetProperty("data").GetProperty("videoGames")[i].ToString());
            }
            return lista;
        }
        /// <summary>
        /// Lista de amigos
        /// </summary>
        /// <returns>Lista con strings</returns>
        public List<string> getAmigos()
        {
            List<string> lista = new List<string>();

            int cantidad = jsonPersonaje.RootElement.GetProperty("data").GetProperty("allies").GetArrayLength();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(jsonPersonaje.RootElement.GetProperty("data").GetProperty("allies")[i].ToString());
            }
            return lista;
        }
        /// <summary>
        /// Lista de enemigos
        /// </summary>
        /// <returns>lista con strings de enemigos</returns>
        public List<string> getEnemigos()
        {
            List<string> lista = new List<string>();

            int cantidad = jsonPersonaje.RootElement.GetProperty("data").GetProperty("enemies").GetArrayLength();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(jsonPersonaje.RootElement.GetProperty("data").GetProperty("enemies")[i].ToString());
            }
            return lista;
        }
        /// <summary>
        /// Enlace de mas informacion
        /// </summary>
        /// <returns>string con la url</returns>
        public string getMasInfo()
        {
            return jsonPersonaje.RootElement.GetProperty("data").GetProperty("sourceUrl").ToString();

        }
        /// <summary>
        /// Imagen del personaje
        /// </summary>
        /// <returns>string con enlace</returns>
        public string getImagen()
        {
            return jsonPersonaje.RootElement.GetProperty("data").GetProperty("imageUrl").ToString();

        }
        /// <summary>
        /// Nombre de personaje
        /// </summary>
        /// <returns>string nombre</returns>
        public string getNombre()
        {
            return jsonPersonaje.RootElement.GetProperty("data").GetProperty("name").ToString();
          
        }







        //Metodos secundarios, se usan para ubicarse en el json

        /// <summary>
        /// Consulta el numero de paginas que tiene el json
        /// </summary>
        /// <returns></returns>
        public int getNumeroPaginas()
        {
            return json.RootElement.GetProperty("info").GetProperty("totalPages").GetInt32();
        }

        /// <summary>
        /// Devuelve el id de un personaje introducida su posicion en el json
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public int getId_pos(int pos)
        {
            return json.RootElement.GetProperty("data")[pos].GetProperty("_id").GetInt32();
             
        }
        /// <summary>
        /// Cantidad de personajes en una pagina default 50
        /// </summary>
        /// <returns>int cantidad de personajes</returns>
        public int getCantidadPersonajesPagina()
        {
            return json.RootElement.GetProperty("info").GetProperty("count").GetInt32();
        }

    }
    
}
