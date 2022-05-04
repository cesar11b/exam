using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace exam
{
    public partial class Form1 : Form
    {
        string ApiKey = "93e1d37e90618f18031fa2e07f14be47";
      


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {




        }

        public void GetLatLon()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtcity.Text, ApiKey);
                    var Json = web.DownloadString(url);
                    LatLon.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(Json);


                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    lblcondicion.Text = Info.weather[0].main;
                    lbldetalles.Text = Info.weather[0].description;
                    lblsunset.Text = ConvertDateTime(Info.sys.sunset).ToShortTimeString();
                    lblsunrise.Text = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();

                    lblwindspeed.Text = Info.wind.speed.ToString();
                    lblpressure.Text = Info.main.pressure.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos no hemos podido encontrar el lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
