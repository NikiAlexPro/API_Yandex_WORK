using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace API_Yandex_WORK
{
    [DataContract]
    public class Fact
    {
        [DataMember(Name = "temp")]
        public int Temperature { get; set; } //Температура

        [DataMember(Name = "wind_speed")]
        public double WindSpeed { get; set; } //Скорость ветра

        [DataMember(Name = "pressure_mm")]
        public int PressureMm { get; set; } //Давление(в мм рт.ст.)

        [DataMember(Name = "humidity")]
        public int Humidity { get; set; } //Влажность воздуха(в процентах)

        [DataMember(Name = "icon")]
        public string Icon { get; set; } //Картинка погоды

        [DataMember(Name = "prec_type")]
        public int PrecType { get; set; } //Тип осадков

        private string precStrengtString;
        [DataMember(Name = "prec_strength")]
        private string PrecStrengtString
        {
            get => precStrengtString;
            set
            {
                precStrengtString = (Convert.ToDouble(value) * 100 / 25).ToString();
            }
        }
        public int PrecStrength //Сила осадков
        {
            get => Convert.ToInt32(PrecStrengtString);
        }

        private string cloudness;
        [DataMember(Name = "cloudness")]
        public string Cloudness
        {
            get => cloudness;
            set
            {
                cloudness = (Convert.ToDouble(value) * 100 / 25).ToString();
            }
        } //Облачность

        [DataMember(Name = "condition")]
        public string Condition { get; set; } //Код расшифровки погодного описания

        [DataMember(Name = "wind_dir")]
        public string WindDirection { get; set; } //Направление ветра
    }

    //[DataContract]
    /*public class Info
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }*/

    [DataContract]
    public class WeatherServiceResponce
    {
        [DataMember(Name = "fact")]
        public Fact CurrentWeather { get; set; }
        
        //[DataMember(Name = "info")]
        //public Info Info { get; set; }
    }
}
