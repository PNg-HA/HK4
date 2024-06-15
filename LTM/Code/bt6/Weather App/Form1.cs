using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Key = "f6ffac5f8bc009b6c71e7e858d053266"; //API Key
        void GetWeather()
        {
            
                
            
        }
        private void SearchBut_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient web = new WebClient();
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityTextBox.Text, Key);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                ConditionLabel.Text = Info.weather[0].main;
                DetailLabel.Text = Info.weather[0].description;
                TempLabel.Text = Info.main.temp.ToString() + "K";
                HumidLabel.Text = Info.main.humidity.ToString() + "%";

                WindLabel.Text = Info.wind.speed.ToString() + " km/h";
                PressureLabel.Text = Info.main.pressure.ToString() + " atm";
            }
            catch
            {
                MessageBox.Show("Nhập đúng tên thành phố!");
            }
            GetWeather();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SunsetLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
