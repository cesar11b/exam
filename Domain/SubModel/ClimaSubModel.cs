using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SubModel
{
    public class ClimaSubModel
    {


        public int Id { get; set; }
        public string Json { get; set; }

        public static ClimaSubModel Convert(Clima clima)
        {
            if (clima == null)
            {
                return null;
            }

            ClimaSubModel climaSubModel = new ClimaSubModel();
            if (climaSubModel.Id < clima.current.weather.Count)
            {
                climaSubModel.Id = clima.current.weather.Count;
            }
            else
            {
                climaSubModel.Id = climaSubModel.Id + 1;
            }
            climaSubModel.Json = JsonConvert.SerializeObject(clima);

            return climaSubModel;
        }

        public static Clima Convert(ClimaSubModel climaSubModel)
        {
            if (climaSubModel == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(climaSubModel.Json))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<Clima>(climaSubModel.Json);
        }


    }
}
