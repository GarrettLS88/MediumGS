using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MediumGS.Client
{
    class Program
    {
        private static readonly HttpClient _client = new HttpClient();
        private static string _url = string.Empty;
        private const string BASE_URL = "http://localhost:51687/api/v1/student";

        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            string cmd = string.Empty;

            while (true)
            {
                Console.WriteLine("Types: GET | POST | PUT | DELETE");
                Console.Write("Enter request type: ");
                cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "get":
                        Console.Write("Leave blank for all or enter /{id}: ");
                        cmd = Console.ReadLine();
                        _url = BASE_URL + cmd;
                        Console.WriteLine("JSON Response:");
                        Console.WriteLine(await Get());
                        _url = string.Empty;
                        break;
                    case "post":
                        Console.Write("JSON: ");
                        cmd = Console.ReadLine();
                        _url = BASE_URL;
                        Console.WriteLine("JSON Response:");
                        Console.WriteLine(await Create(cmd));
                        _url = string.Empty;
                        break;
                    case "put":
                        Console.Write("JSON: ");
                        cmd = Console.ReadLine();
                        _url = BASE_URL;
                        Console.WriteLine("Response Status:");
                        Console.WriteLine(await Update(cmd));
                        _url = string.Empty;
                        break;
                    case "delete":
                        Console.Write("Enter /{id}: ");
                        cmd = Console.ReadLine();
                        _url = BASE_URL + cmd;
                        Console.WriteLine("Response Status:");
                        Console.WriteLine(await Delete());
                        _url = string.Empty;
                        break;
                    default:
                        return;
                }
            }
        }

        private static async Task<string> Get()
        {
            HttpResponseMessage response = await _client.GetAsync(_url);
            return response.Content.ReadAsStringAsync().Result.ToString();
        }

        private static async Task<string> Create(string json)
        {
            HttpResponseMessage response = await _client.PostAsync(_url, CreateContent(json));
            return response.Content.ReadAsStringAsync().Result;
        }

        private static async Task<HttpStatusCode> Update(string json)
        {
            HttpResponseMessage response = await _client.PutAsync(_url, CreateContent(json));
            return response.StatusCode;
        }

        private static async Task<HttpStatusCode> Delete()
        {
            HttpResponseMessage response = await _client.DeleteAsync(_url);
            return response.StatusCode;
        }

        private static ByteArrayContent CreateContent(string json)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(json);
            ByteArrayContent content = new ByteArrayContent(buffer);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return content;
        }
    }
}
