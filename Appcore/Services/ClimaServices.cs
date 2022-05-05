using Appcore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Services
{
    public class ClimaServices : BaseServices<Clima>, IWeatherService
    {

        IWeatherModel climaModel;
        public ClimaServices(IWeatherModel model) : base(model)
        {
            this.climaModel = model;
        }

        public DateTime Tiempo(long g)
        {
            return climaModel.Tiempo(g);
        }
    }
}
