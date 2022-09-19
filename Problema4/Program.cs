// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Problema4 
{
   class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                Root prov = null;

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string texto = objReader.ReadToEnd();

                                prov = JsonSerializer.Deserialize<Root>(texto);
                            }
                        }
                    }
                }

                if (prov != null)
                {
                    Mostrar(prov);
                }
            }
            catch (WebException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (ProtocolViolationException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (IOException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (JsonException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"\nError detectado");
            }
        }

         private static void Mostrar(Root prov)
        {
            for (int i = prov.Inicio; i < prov.Cantidad; i++)
            {
                Console.WriteLine($"\nId: {prov.Provincias[i].Id}");
                Console.WriteLine($"Provincia: {prov.Provincias[i].Nombre}");
            }
        }
        }
    }


