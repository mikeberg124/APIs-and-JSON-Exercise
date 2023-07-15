using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {

        public static void CurrentWeather()
        {
            var client = new HttpClient();
            var apiKey = "50642d894f0f14145e83c3400e92ec0b";
            Console.WriteLine("Enter a city name");
            var cityName = Console.ReadLine();
            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
            var weatherResponse = client.GetStringAsync(weatherUrl).Result;
            var wObject = JObject.Parse(weatherResponse);
            Console.WriteLine($"The cureent weather is: \n {wObject ["main"]["temp"]}");
            Console.WriteLine();
            Console.WriteLine($"{wObject["weather"][0]["description"]}");



        }
    }
}
