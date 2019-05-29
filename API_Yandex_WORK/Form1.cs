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
            string res = textBox1.Text;
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
                    var proj = fact.CurrentWeather.ToFactProjection();
                    weathers.Add(proj);
                    //var info = JsonConvert.DeserializeObject<WeatherServiceResponce>(n);
                    labelTemperature.Text = "Температура: " + fact.CurrentWeather.Temperature + " °C";
                    labelWindSpeed.Text = "Скорость ветра: " + fact.CurrentWeather.WindSpeed + " м/с";
                    labelPressureMm.Text = "Давление: " + fact.CurrentWeather.PressureMm + " мм рт.ст.";
                    labelHumidity.Text = "Влажность воздуха: " + fact.CurrentWeather.Humidity + " %";
                    labelPrecType.Text = $"Тип осадков: {PrecTypeView[proj.PrecType]}";
                    labelPrecStrength.Text = $"Сила осадков: {PrecStrengthViev[proj.PrecStrength]}";
                    labelCloudness.Text = $"Облачность: {CloudnessView[proj.Cloudness]}";
                    labelCondition.Text = $"Погодное описание: {ConditionView[proj.Condition]}";
                    labelWindDirection.Text = $"Направление ветра: {WindDirectionView[proj.WindDirection]}";
                    labelNameCity.Text = "Местоположение: " + res;
                    //Console.WriteLine($"{result}");
                    //Console.WriteLine(Webstream.ReadToEnd());
                    //pictureBox1.Image
                    pictureBox1.ImageLocation = "https://cdn.dribbble.com/users/27990/screenshots/1983809/weather_teaser.png";
                    Console.ReadLine();
                }
            }
            response.Close();

        }
    }
}



