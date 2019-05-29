using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization;

namespace API_Yandex_WORK
{
    [DataContract]
    public class GeocoderResponseContainer
    {
        [DataMember(Name = "response")]
        public GeocoderResponse Response { get; set; }//Координаты точки
    }

    [DataContract]
    public class GeocoderResponse
    {
        [DataMember(Name = "GeoObjectCollection")]
        public GeoObjectCollection GeoObjectCollection { get; set; }//Координаты точки
    }
    
    [DataContract]
    public class GeoObjectCollection
    {
        [DataMember(Name = "featureMember")]
        public FeatureMember [] FeatureMember { get; set; }//Координаты точки
    }

    [DataContract]
    public class FeatureMember
    {
        [DataMember(Name = "GeoObject")]
        public GeoObject GeoObject { get; set; }//Координаты точки
    }

    [DataContract]
    public class GeoObject
    {
        [DataMember(Name = "Point")]
        public Point Point { get; set; }//Координаты точки
    }

    [DataContract]
    public class Point
    {
        [DataMember(Name = "pos")]
        public string GeoPoint { get; set; }//Координаты точки
    }
    
    /*
    [DataContract]
    public class FindPoint
    {
        [DataMember(Name = "Point")]

    }
    */
}
