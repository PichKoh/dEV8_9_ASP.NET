using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using WebApplication8.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
namespace WebApplication8.Pages
{
    [IgnoreAntiforgeryToken]
    public class WeatherModel : PageModel
    {
        public WeatherData Weather;
        public void OnGet()
        {
        }
        public void OnPost(string city)
        {
            string json;
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric" +
                $"&appid=b4af138646d645c952b8e9b795cbabe4";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }
            Weather = JsonConvert.DeserializeObject<WeatherData>(json);
        }
    }
}
