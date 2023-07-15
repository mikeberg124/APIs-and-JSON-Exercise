using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void Convo()
        {



            var client = new HttpClient();



            for (int i = 0; i < 6; i++)
            {

                var kanyeUrl = "https://api.kanye.rest/";

                var kRepsone = client.GetStringAsync(kanyeUrl).Result;
                var kObject = JsonNode.Parse(kRepsone);
                Console.WriteLine($"Kayne:{kObject["quote"]}");
                Console.WriteLine();


                var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var rResponse = client.GetStringAsync(ronUrl).Result;
                JsonNode rObject = JsonNode.Parse(rResponse);
                Console.WriteLine($"Ron:{rObject[0]}");
                Console.WriteLine();

            }
            
        }

    }
}
