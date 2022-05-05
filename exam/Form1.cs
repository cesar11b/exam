using Appcore.Interfaces;
using Appcore.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace exam
{
    public partial class Form1 : Form
    {
        IWeatherService climaServices;
        string ApiKey = "93e1d37e90618f18031fa2e07f14be47";
        Clima clima;


        public Form1(IWeatherService ClimaServices)
        {
            this.climaServices = ClimaServices;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Paneles()
        {



            WeatherPanel weatherPanel = new WeatherPanel();
            weatherPanel.lblCity.Text = txtCity.Text;
            Clima clima = climaServices.Extracción(txtCity.Text);
            if (clima == null)
            {
                MessageBox.Show("No se encontró o no existe esta ciudad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            weatherPanel.Paneles(clima);
            flpContent.Controls.Add(weatherPanel);



        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtCity.Text == string.Empty || txtCity == null)
            {
                MessageBox.Show("Debe escribir una ciudad valida");
                return;

            }
            
            
            Paneles();
            
            txtCity.Text = string.Empty;




        }


    }
}
