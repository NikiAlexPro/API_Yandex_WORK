using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace API_Yandex_WORK
{
    public static class CommonConverter
    {
        static CommonConverter()
        {
            AutoMapper.Mapper.CreateMap<Fact, FactProjection>()
                .ForMember(x => x.Condition, xproj => xproj.MapFrom(x =>
                ConditionRespToConst[x.Condition]))
                .ForMember(x => x.WindDirection, xproj => xproj.MapFrom(x => 
                WindDirectionRespTool[x.WindDirection]));
        }

        public static FactProjection ToFactProjection(this Fact item)
        {
            return Mapper.Map<Fact, FactProjection>(item);
        }

        public static Dictionary<PrecType, string> PrecTypeView { get; } = new Dictionary<PrecType, string>
        {
            { PrecType.NoFallout, "без осадков" },
            { PrecType.Rain,  "дождь"},
            { PrecType.RainAndSnow, "дождь со снегом" },
            { PrecType.Snow, "снег" }
        };

        public static Dictionary<PrecStrength, string> PrecStrengthViev { get; } = new Dictionary<PrecStrength, string>
        {
            {PrecStrength.WithoutFallout, "без осадков" },
            {PrecStrength.EasyRain, "слабый дождь/слабый снег" },
            {PrecStrength.Rain, "дождь/снег" },
            {PrecStrength.HardRain, "сильный дождь/сильный снег" },
            {PrecStrength.HeavyRain, "сильный ливень/очень сильный снег" }
        };

        public static Dictionary<string, Condition> ConditionRespToConst { get; } = new Dictionary<string, Condition>
        {
            { "clear", Condition.Clear },
            { "partly-cloudy", Condition.PartlyCloudy},
            { "cloudy", Condition.Cloudy },
            { "overcast", Condition.Overcast },
            { "partly-cloudy-and-light-rain", Condition.PartlyCloudyAndLightRain },
            { "partly-cloudy-and-rain", Condition.PartlyCloudyAndRain },
            { "overcast-and-rain", Condition.OvercastAndRain },
            { "overcast-thunderstorms-with-rain", Condition.OvercastThunderstormsWithRain },
            { "cloudy-and-light-rain", Condition.CloudyAndLightRain },
            { "overcast-and-light-rain", Condition.OvercastAndLightRain },
            { "cloudy-and-rain", Condition.CloudyAndRain },
            { "overcast-and-wet-snow ", Condition.OvercastAndWetSnow },
            { "partly-cloudy-and-light-snow", Condition.PartlyCloudyAndLightSnow },
            { "partly-cloudy-and-snow", Condition.PartlyCloudyAndSnow },
            { "overcast-and-snow", Condition.OvercastAndSnow },
            { "cloudy-and-light-snow", Condition.CloudyAndLightSnow },
            { "overcast-and-light-snow", Condition.OvercastAndLightSnow },
            { "cloudy-and-snow", Condition.CloudyAndSnow }
        };

        public static Dictionary<Condition, string> ConditionView { get; } = new Dictionary<Condition, string>
        {
            { Condition.Clear, "ясно" },
            { Condition.PartlyCloudy, "малооблачно" },
            { Condition.Cloudy, "облачно с прояснениями" },
            { Condition.Overcast, "пасмурно" },
            { Condition.PartlyCloudyAndLightRain, "небольшой дождь" },
            { Condition.PartlyCloudyAndRain, "дождь" },
            { Condition.OvercastAndRain, "сильный дождь" },
            { Condition.OvercastThunderstormsWithRain, "сильный дождь, гроза" },
            { Condition.CloudyAndLightRain, "небольшой дождь" },
            { Condition.OvercastAndLightRain, "небольшой дождь" },
            { Condition.CloudyAndRain, "дождь" },
            { Condition.OvercastAndWetSnow, "дождь со снегом" },
            { Condition.PartlyCloudyAndLightSnow, "небольшой снег" },
            { Condition.PartlyCloudyAndSnow, "снег" },
            { Condition.OvercastAndSnow, "снегопад" },
            { Condition.CloudyAndLightSnow, "небольшой снег" },
            { Condition.OvercastAndLightSnow, "небольшой снег" },
            { Condition.CloudyAndSnow, "снег" }
        };

        public static Dictionary<Cloudness, string> CloudnessView { get; } = new Dictionary<Cloudness, string>
        {
            { Cloudness.Clear, "ясно" },
            { Cloudness.LowCloud, "малооблачно" },
            { Cloudness.CloudyWithClarification, "облачно с прояснениями" },
            { Cloudness.CloudyWithClarifications, "облачно с прояснениями" },
            { Cloudness.Cloudy, "пасмурно"}
        };

        public static Dictionary<string, WindDirection> WindDirectionRespTool { get; } = new Dictionary<string, WindDirection>
        {
            { "nw", WindDirection.NorthWest },
            { "n", WindDirection.North },
            { "ne", WindDirection.NorthEast },
            { "e", WindDirection.East },
            { "se", WindDirection.SouthEast },
            { "s", WindDirection.South },
            { "sw", WindDirection.SouthWest },
            { "w", WindDirection.West },
            { "c", WindDirection.Calm }
        };

        public static Dictionary<WindDirection, string> WindDirectionView { get; } = new Dictionary<WindDirection, string>
        {
            { WindDirection.NorthWest, "северо-западное" },
            { WindDirection.North, "северное" },
            { WindDirection.NorthEast, "северо-восточное" },
            { WindDirection.East, "восточное" },
            { WindDirection.SouthEast, "юго-восточное" },
            { WindDirection.South, "южное" },
            { WindDirection.SouthWest, "юго-западное" },
            { WindDirection.West, "западное" },
            { WindDirection.Calm, "штиль" }
        };
    }

    public enum PrecType
    {
        NoFallout = 0,
        Rain = 1,
        RainAndSnow = 2,
        Snow = 3
    }

    public enum PrecStrength
    {
        WithoutFallout = 0,
        EasyRain = 1,
        Rain = 2,
        HardRain = 3,
        HeavyRain = 4
    }

    public enum Condition
    {
        Clear = 0,
        PartlyCloudy,
        Cloudy,
        Overcast,
        PartlyCloudyAndLightRain,
        PartlyCloudyAndRain,
        OvercastAndRain,
        OvercastThunderstormsWithRain,
        CloudyAndLightRain,
        OvercastAndLightRain,
        CloudyAndRain,
        OvercastAndWetSnow,
        PartlyCloudyAndLightSnow,
        PartlyCloudyAndSnow,
        OvercastAndSnow,
        CloudyAndLightSnow,
        OvercastAndLightSnow,
        CloudyAndSnow
    }

    public enum Cloudness
    {
        Clear = 0,
        LowCloud,
        CloudyWithClarification,
        CloudyWithClarifications,
        Cloudy
    }

    public enum WindDirection
    {
        NorthWest = 0,
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        Calm
    }

    public class FactProjection
    {
        public int Temperature { get; set; } //Температура

        public double WindSpeed { get; set; } //Скорость ветра

        public int PressureMm { get; set; } //Давление(в мм рт.ст.)

        public int Humidity { get; set; } //Влажность воздуха(в процентах)

        public PrecType PrecType { get; set; } //Тип осадков

        public PrecStrength PrecStrength { get; set; } //Сила осадков

        public Cloudness Cloudness { get; set; } //Облачность

        public Condition Condition { get; set; } //Код расшифровки погодного описания

        public WindDirection WindDirection { get; set; } //Направление ветра
    }
}
