using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interfaces
{
    public interface IWeatherService : IService<Clima>
    {

        DateTime Tiempo(long g);
    }
}
