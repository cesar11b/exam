using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository : IWeatherModel
    {
        static string APIKey = "fb559a98a6a1dc5e73131299c9b50f08";




        public DateTime En_tiempo(long g)
        {
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(g).ToLocalTime();
return day;
}
        }

        public Clima Extraccion(string t)
        {
            try
            {


                using (WebClient web = new WebClient())
                {

                    string url1 = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", t, APIKey);
                    var json1 = web.DownloadString(url1);

                    City ciudades = JsonConvert.DeserializeObject<City>(json1);

                    DateTime a = En_tiempo((long)ciudades.Dt);
                    a.AddDays(-5);
                    long DT = a.Ticks;


                    string url2 = string.Format("http://api.openweathermap.org/data/2.5/onecall/timemachine?lat={0}&lon={1}&units=metric&dt={2}&lang=sp&appid={3}", ciudades.coord.Lat, ciudades.coord.Lon, DT, APIKey);
                    var json2 = web.DownloadString(url2);
Clima datos = JsonConvert.DeserializeObject<Clima>(json2);
return datos;
}
            }
            catch (Exception)
            {
                Clima datos = null;
return datos;

            }
        }




    }
}
