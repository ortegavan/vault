using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Teste
{
    class Program 
    {
        static async Task Main(string[] args)
        {
            var httpClient = HttpClientFactory.Create();
            httpClient.DefaultRequestHeaders.Add("X-Vault-Token", "s.kZPGNhm5evk1oDMV2wSIlaw5");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = "http://127.0.0.1:8200/v1/cubbyhole/gatos";

            var json = JObject.Parse(await httpClient.GetStringAsync(url));

            Console.WriteLine(json);
        }
    }
}