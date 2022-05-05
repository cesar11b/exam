using Appcore.Interfaces;
using Appcore.Services;
using Autofac;
using Domain.Interfaces;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterType<BaseRepository>().As<IWeatherModel>();
            builder.RegisterType<ClimaServices>().As<IWeatherService>();
            var container = builder.Build();

            Application.Run(new Form1(container.Resolve<IWeatherService>()));




        }
    }
}
