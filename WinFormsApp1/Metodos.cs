using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public class Metodos
    {
        string apiUrl = "https://api.apis.net.pe/v2/reniec/dni?numero=";
        string apiUrlSunat = "https://api.apis.net.pe/v2/sunat/ruc/full?numero";


        List<jsonKeys> jsonKeys = null;
        string key = "";
        public Metodos()
        {
            jsonKeys = new List<jsonKeys>();
        }

        public List<jsonKeys> obtenerKey()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Resources", "tokens.json");
            bool existArchivo = true;

            // Verifica que el archivo exista
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"El archivo no se encuentra en la ruta: {filePath}");
                existArchivo = false;
            }

            if(existArchivo)
            {
                try
                {
                    // Lee el contenido del archivo JSON
                    string jsonString = File.ReadAllText(filePath);

                    // Deserializa el JSON a una lista de objetos
                    var tokens = JsonConvert.DeserializeObject<List<jsonKeys>>(jsonString);

                    if (tokens != null)
                    {
                        jsonKeys = new List<jsonKeys>();
                        // Usa los objetos
                        foreach (var token in tokens)
                        {
                            //Agrega token a la lista
                            jsonKeys.Add(token);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La lista deserializada es null.");
                    }
                }
                catch (JsonException jsonEx)
                {
                    Console.WriteLine($"Error al deserializar el JSON: {jsonEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error general: {ex.Message}");
                }
            }
            seleccionarKey();
            return jsonKeys;
        }

        public void seleccionarKey()
        {
            Random random = new Random();
            int cantidadKeys = 0;
            cantidadKeys = jsonKeys.Count();
            int numeroAleatorio = random.Next(0, cantidadKeys - 1);
            key = jsonKeys[numeroAleatorio].token;
        }

        public async Task<respuestaDNI> ConsultaDatosReniec(string numeroDocumento)
        {
            obtenerKey();
            respuestaDNI entidad = new respuestaDNI();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Configura el encabezado "Authorization" con el token de tipo Bearer
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
                    // Realiza una solicitud GET al servicio
                    HttpResponseMessage response = await client.GetAsync(apiUrl + numeroDocumento);
                    // Verifica si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena
                        string responseBody = await response.Content.ReadAsStringAsync();
                        entidad = JsonConvert.DeserializeObject<respuestaDNI>(responseBody);
                        Console.WriteLine("Respuesta del servicio:");
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Error en la solicitud. Código de estado: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return entidad;
        }


        public async Task<respuestaSunat> ConsultaDatosSunat(string numeroDocumento)
        {
            obtenerKey();
            respuestaSunat entidad = new respuestaSunat();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Configura el encabezado "Authorization" con el token de tipo Bearer
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
                    // Realiza una solicitud GET al servicio
                    HttpResponseMessage response = await client.GetAsync(apiUrlSunat + numeroDocumento);
                    // Verifica si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena
                        string responseBody = await response.Content.ReadAsStringAsync();
                        entidad = JsonConvert.DeserializeObject<respuestaSunat>(responseBody);
                        Console.WriteLine("Respuesta del servicio:");
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Error en la solicitud. Código de estado: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return entidad;
        }

    }
}
