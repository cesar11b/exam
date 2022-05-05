using Domain.Entities;
using Domain.Interfaces;
using Domain.SubModel;
using Newtonsoft.Json;
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



        public DateTime Tiempo(long g)
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
                    Clima datos;
                    string url1 = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", t, APIKey);
                    var json1 = web.DownloadString(url1);

                    Ciudad ciudades = JsonConvert.DeserializeObject<Ciudad>(json1);


                    long DT = ciudades.Dt - 400000;


                    string url2 = string.Format("http://api.openweathermap.org/data/2.5/onecall/timemachine?lat={0}&lon={1}&units=metric&dt={2}&lang=sp&appid={3}", ciudades.coord.Lat, ciudades.coord.Lon, DT, APIKey);
                    var json2 = web.DownloadString(url2);

                    datos = JsonConvert.DeserializeObject<Clima>(json2);

                    datos.Name = t;

                    return datos;

                }
            }
            catch (Exception)
            {
                Clima datos = null;
                return datos;

            }
        }
        private RAFContext context;
        private int SIZE = 9000;

        public BaseRepository()
        {
            context = new RAFContext("climaSubModel", SIZE);
        }

        public void Add(Clima t)
        {
            try
            {

                ClimaSubModel climaSubModel = ClimaSubModel.Convert(t);
                context.Create<ClimaSubModel>(climaSubModel);
            }
            catch (Exception)
            {
                throw;
            }
        }



        public List<Clima> Read()
        {
            List<ClimaSubModel> activoSubModels = context.GetAll<ClimaSubModel>();
            return activoSubModels.Count == 0 ? new List<Clima>() :
                   activoSubModels.Select(x => ClimaSubModel.Convert(x)).ToList();
        }



    }
}
