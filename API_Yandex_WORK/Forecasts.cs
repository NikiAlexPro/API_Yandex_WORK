using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace API_Yandex_WORK
{
    [DataContract]
    public class ForecastsContainer
    {
        [DataMember(Name = "forecasts")]
        public Forecasts[] Forecasts { get; set; }
    }

    [DataContract]
    public class Forecasts
    {
        [DataMember(Name = "parts")]
        public Parts Parts { get; set; }
    }

    [DataContract]
    public class Parts
    {
        [DataMember(Name = "day_short")]
        public Day Day { get; set; }
    }

    [DataContract]
    public class Day
    {
        [DataMember(Name = "temp")]
        public int Temperature { get; set; } // Температура

        [DataMember(Name = "icon")]
        public string Icon { get; set; } //Код картинки погоды

        [DataMember(Name = "condition")]
        public string Condition { get; set; } //Код погодного описания

        [DataMember(Name = "wind_speed")]
        public double WindSpeed { get; set; } //Скорость ветра

        [DataMember(Name = "wind_dir")]
        public string WindDirection { get; set; } //Направление ветра

        [DataMember(Name = "pressure_mm")]
        public int PressureMm { get; set; } //Давление 
    }
    
}
