using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace RTUnofficial.ApiClient.Models
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                //IndexConverter.Singleton,
                TypeEnumConverter.Singleton,
                //ChannelSlugConverter.Singleton,
                OrderConverter.Singleton,
                CastMemberTypeConverter.Singleton,
                ImageTypeEnumConverter.Singleton,
                OrientationConverter.Singleton,
                ImageTypeConverter.Singleton,
                TagTypeConverter.Singleton,
                //ChannelConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    public static class Serialize
    {
        public static string ToJson(this Episodes self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Videos self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Channels self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Shows self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Seasons self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Livestreams self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this TokenRequest self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this Token self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
