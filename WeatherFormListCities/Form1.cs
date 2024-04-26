using System;
using System.Net;
using System.Text.Json;
using System.Windows.Forms;



namespace WeatherFormListCities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "ab2ac8f50aa62fc7ddfdce05ec5b1fac";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {


                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TBCityA.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonSerializer.Deserialize<WeatherInfo.root>(json, options);

                picIconA.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCityA.Text = Info.main.temp.ToString();

                url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TBCityB.Text, APIKey);
                json = web.DownloadString(url);
                Info = JsonSerializer.Deserialize<WeatherInfo.root>(json, options);

                picIconB.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCityB.Text = Info.main.temp.ToString();

                url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TBCityC.Text, APIKey);
                json = web.DownloadString(url);
                Info = JsonSerializer.Deserialize<WeatherInfo.root>(json, options);


                picIconC.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCityC.Text = Info.main.temp.ToString();


                //labCondition.Text = Info.weather[0].main;
                //labDetails.Text = Info.weather[0].description;
                //labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                //labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                //labWind.Text = Info.wind.speed.ToString();
                //labPressure.Text = Info.main.pressure.ToString();
            }

        }
        DateTime convertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }

    }
}
