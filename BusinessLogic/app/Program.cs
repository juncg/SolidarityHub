using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        var httpClient = new HttpClient();
        var url = "http://localhost:5170/api/people";

        var person = new {name = "John Doe", email = "john@example.com" };
        var json = JsonConvert.SerializeObject(person);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(url, content);
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
}