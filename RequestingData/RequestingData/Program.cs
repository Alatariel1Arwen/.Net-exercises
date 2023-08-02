using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Inserisci l'URL: ");
            string url = Console.ReadLine();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    string content = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Intestazioni della risposta:");
                    foreach (var header in response.Headers)
                    {
                        Console.WriteLine($"{header.Key}: {string.Join(",", header.Value)}");
                    }

                    Console.WriteLine("\nContenuto della risposta:");
                    Console.WriteLine(content);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Si è verificato un errore durante la richiesta: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }
        }
    }
}
