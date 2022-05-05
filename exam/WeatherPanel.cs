using Domain.Entities;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class WeatherPanel : UserControl
    {
        public WeatherPanel()
        {
            InitializeComponent();
        }
        BaseRepository baseRepository = new BaseRepository();
        private void flpContent_Paint(object sender, PaintEventArgs e)
        {

        }



        public void Paneles(Clima clima)
        {


            lblTemperature.Text = "C° " + clima.current.Temp.ToString();
            lblWeather.Text = clima.current.weather[0].Main;
        

            #region detail

            DetailsValues DetailsValuess0 = new DetailsValues();
            DetailsValuess0.lblDetail.Text = "Fecha";
            DetailsValuess0.lblDetailValue.Text = baseRepository.Tiempo(clima.hourly[0].dt).ToShortDateString();
            flpContent.Controls.Add(DetailsValuess0);

            DetailsValues DetailsValuess15 = new DetailsValues();
            DetailsValuess15.lblDetail.Text = "Hora";
            DetailsValuess15.lblDetailValue.Text = baseRepository.Tiempo(clima.hourly[0].dt).ToShortTimeString();
            flpContent.Controls.Add(DetailsValuess15);

            DetailsValues DetailsValuess1 = new DetailsValues();
            DetailsValuess1.lblDetail.Text = "Descripcion";
            DetailsValuess1.lblDetailValue.Text = clima.hourly[0].weather[0].Description;
            flpContent.Controls.Add(DetailsValuess1);

            DetailsValues DetailsValuess2 = new DetailsValues();
            DetailsValuess2.lblDetail.Text = "Nubosidad";
            DetailsValuess2.lblDetailValue.Text = clima.hourly[0].Clouds.ToString() + "%";
            flpContent.Controls.Add(DetailsValuess2);

            DetailsValues DetailsValuess3 = new DetailsValues();
            DetailsValuess3.lblDetail.Text = "Viento";
            DetailsValuess3.lblDetailValue.Text = clima.hourly[0].wind_speed.ToString() + " mt/s";
            flpContent.Controls.Add(DetailsValuess3);

            DetailsValues DetailsValuess4 = new DetailsValues();
            DetailsValuess4.lblDetail.Text = "Direccion del viento";
            DetailsValuess4.lblDetailValue.Text = clima.hourly[0].wind_deg.ToString() + "°";
            flpContent.Controls.Add(DetailsValuess4);

            DetailsValues DetailsValuess5 = new DetailsValues();
            DetailsValuess5.lblDetail.Text = "Rayos UV";
            DetailsValuess5.lblDetailValue.Text = clima.hourly[0].uvi.ToString() + " UVI";
            flpContent.Controls.Add(DetailsValuess5);

            DetailsValues DetailsValuess6 = new DetailsValues();
            DetailsValuess6.lblDetail.Text = "Amanecer";
            DetailsValuess6.lblDetailValue.Text = baseRepository.Tiempo((long)clima.current.Sunrise).ToShortTimeString();
            flpContent.Controls.Add(DetailsValuess6);


            DetailsValues DetailsValuess7 = new DetailsValues();
            DetailsValuess7.lblDetail.Text = "Atardecer";
            DetailsValuess7.lblDetailValue.Text = baseRepository.Tiempo((long)clima.current.Sunset).ToShortTimeString();
            flpContent.Controls.Add(DetailsValuess7);

            DetailsValues DetailsValuess8 = new DetailsValues();
            DetailsValuess8.lblDetail.Text = "Presión";
            DetailsValuess8.lblDetailValue.Text = clima.hourly[0].Pressure.ToString() + "/hPa";
            flpContent.Controls.Add(DetailsValuess8);

            DetailsValues DetailsValuess9 = new DetailsValues();
            DetailsValuess9.lblDetail.Text = "Humedad";
            DetailsValuess9.lblDetailValue.Text = clima.hourly[0].Humidity.ToString() + "%";
            flpContent.Controls.Add(DetailsValuess9);


            DetailsValues DetailsValuess10 = new DetailsValues();
            DetailsValuess10.lblDetail.Text = "Latitud";
            DetailsValuess10.lblDetailValue.Text = clima.Lat + "°";
            flpContent.Controls.Add(DetailsValuess10);

            DetailsValues DetailsValuess11 = new DetailsValues();
            DetailsValuess11.lblDetail.Text = "Longitud";
            DetailsValuess11.lblDetailValue.Text = clima.Lon + "°";
            flpContent.Controls.Add(DetailsValuess11);



            #endregion

        }



    }
}
