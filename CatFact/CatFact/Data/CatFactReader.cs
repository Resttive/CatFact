using CatFact.Models;
using Newtonsoft.Json;
using System.Net;

namespace CatFact.Data
{
    public class CatFactReader : ICatFactReader
    {
        WebClient client = new WebClient();
        string baseUri = "https://catfact.ninja";

        public FactCat GetFact()
        {
            string result = client.DownloadString($"{baseUri}/fact");
            var fact = JsonConvert.DeserializeObject<FactCat>(result);
            return fact;
        }
    }
}
