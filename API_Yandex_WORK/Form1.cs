using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.IO;
using AutoMapper;
using static API_Yandex_WORK.CommonConverter;

namespace API_Yandex_WORK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        static double slat = 1488;//52.841058;
        static double slon = 666; //33.196056;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Геокодер для определения местоположения
            //double lat = 52.841058; //Широта (в градусах).
            //double lon = 33.196056; //Долгота (в градусах).///
            groupBoxTommorow.Text = "Погода на завтра:";
            

        }
        static List<FactProjection> weathers = new List<FactProjection>();   
        public string ToYandexCoordinate(double val)
        {
            var tmp = new StringBuilder(val.ToString());
            tmp.Replace(',', '.');
            return tmp.ToString();
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            string res = richTextBox1.Text;
            labelNameCity.Text = res;
            //Запрос Яндекс.Геокодер
            HttpWebRequest requestGeo = (HttpWebRequest)WebRequest.Create($"https://geocode-maps.yandex.ru/1.x/?apikey=737dd3bf-9479-4896-9e7f-85b5303c8f75&format=json&geocode={res}&results=1");

            HttpWebResponse responseGeo = (HttpWebResponse)requestGeo.GetResponse();

            using (Stream streamGeo = responseGeo.GetResponseStream())
            {
                using (StreamReader WebstreamGeo = new StreamReader(streamGeo))
                {
                    string streamres = WebstreamGeo.ReadToEnd();
                    var fact = JsonConvert.DeserializeObject<GeocoderResponseContainer>(streamres);
                    var proj = fact.Response.GeoObjectCollection.FeatureMember[0].GeoObject.Point.GeoPoint;

                    StringBuilder tmp = new StringBuilder(proj);
                    tmp.Replace('.',',');
                    string[] latlan = tmp.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string lats = latlan[1];
                    string lons = latlan[0];

                    slat = Convert.ToDouble(lats);
                    slon = Convert.ToDouble(lons);

                    //var сосиска = slat.ToString();

                }
            }
            //53.243562
            //34.363407
            ///
            //52.92913 33.454267
            //Запрос Яндекс.Погода
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.weather.yandex.ru/v1/forecast?lat={ToYandexCoordinate(slat)}&lon={ToYandexCoordinate(slon)}&extra=false");
            request.Method = "GET";
            request.Headers = new WebHeaderCollection() { { "X-Yandex-API-Key", "07bd7941-278f-416c-812d-4ad5e3ae333d" } };
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //var webResponse = result.Result; 
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader Webstream = new StreamReader(stream))
                {
                    string n = Webstream.ReadToEnd();
                    //JNDeserialize jnDeserialize = JsonConvert.DeserializeObject<JNDeserialize>(n);
                    //long result = jnDeserialize.now;
                    var fact = JsonConvert.DeserializeObject<WeatherServiceResponce>(n);
                    var forecasts = JsonConvert.DeserializeObject<ForecastsContainer>(n);
                    var proj = fact.CurrentWeather.ToFactProjection();
                    var projforecasts = forecasts.Forecasts[1].Parts.Day.ToForecastsProjection();
                    var projforecastsAf = forecasts.Forecasts[2].Parts.Day.ToForecastsProjection();
                    weathers.Add(proj);
                    weathers.Add(projforecasts);
                    weathers.Add(projforecastsAf);
                    
                    //var info = JsonConvert.DeserializeObject<WeatherServiceResponce>(n);
                    //labelWeatherNow
                    labelTemperature.Text = "Температура: " + fact.CurrentWeather.Temperature + " °C";
                    labelWindSpeed.Text = "Скорость ветра: " + fact.CurrentWeather.WindSpeed + " м/с";
                    labelPressureMm.Text = "Давление: " + fact.CurrentWeather.PressureMm + " мм рт.ст.";
                    labelHumidity.Text = "Влажность воздуха: " + fact.CurrentWeather.Humidity + " %";
                    //labelPrecType.Text = $"Тип осадков: {PrecTypeView[proj.PrecType]}";
                    //labelPrecStrength.Text = $"Сила осадков: {PrecStrengthViev[proj.PrecStrength]}";
                    labelCloudness.Text = $"Облачность: {CloudnessView[proj.Cloudness]}";
                    labelCondition.Text = $"Погодное описание: {ConditionView[proj.Condition]}";
                    labelWindDirection.Text = $"Направление ветра: {WindDirectionView[proj.WindDirection]}";
                    labelNameCity.Text = "Местоположение: " + res;
                    string IconNow = fact.CurrentWeather.Icon;
                    webBrowserNow.Navigate($"https://yastatic.net/weather/i/icons/blueye/color/svg/{IconNow}.svg");
                    
                    //labelWeatherTommorow
                    labelTemperatureTomw.Text = "Температура: " + forecasts.Forecasts[1].Parts.Day.Temperature + " °C";
                    labelWindSpeedTomw.Text = "Скорость ветра: " + forecasts.Forecasts[1].Parts.Day.WindSpeed + " м/с";
                    labelPressureMmTomw.Text = "Давление: " + forecasts.Forecasts[1].Parts.Day.PressureMm + " мм рт.ст.";
                    labelConditionTomw.Text = $"Погодное описание: {ConditionView[projforecasts.Condition]}";
                    labelWindDirectionTomw.Text = $"Направление ветра: {WindDirectionView[projforecasts.WindDirection]}";
                    string IconTommorow = forecasts.Forecasts[1].Parts.Day.Icon;
                    webBrowserTommorow.Navigate($"https://yastatic.net/weather/i/icons/blueye/color/svg/{IconTommorow}.svg");

                    //labelWeatherAfterTomorrow
                    labelTemperatureAfTomw.Text = "Температура: " + forecasts.Forecasts[2].Parts.Day.Temperature + " °C";
                    labelWindSpeedAfTomw.Text = "Скорость ветра: " + forecasts.Forecasts[2].Parts.Day.WindSpeed + " м/с";
                    labelPressureMmAfTomw.Text = "Давление: " + forecasts.Forecasts[2].Parts.Day.PressureMm + " мм рт.ст.";
                    labelConditionAfTomw.Text = $"Погодное описание: {ConditionView[projforecastsAf.Condition]}";
                    labelWindDirectionAfTomw.Text = $"Направление ветра: {WindDirectionView[projforecastsAf.WindDirection]}";
                    string IconAfTommorow = forecasts.Forecasts[2].Parts.Day.Icon;
                    webBrowserAfTommorow.Navigate($"https://yastatic.net/weather/i/icons/blueye/color/svg/{IconAfTommorow}.svg");


                }
            }
            response.Close();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}



