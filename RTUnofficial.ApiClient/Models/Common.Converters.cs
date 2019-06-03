using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// automatically generated converters that are common in the rt apis

namespace RTUnofficial.ApiClient.Models
{
    
    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch(value)
            {
                case "episode":
                    return TypeEnum.Episode;
                    
                case "show":
                    return TypeEnum.Show;

                case "season":
                    return TypeEnum.Season;


            }
            //if (value == "episode")
            //{
            //    return TypeEnum.Episode;
            //}
            
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Episode)
            {
                serializer.Serialize(writer, "episode");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }



    internal class OrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Order) || t == typeof(Order?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "asc":
                    return Order.Asc;
                case "desc":
                    return Order.Desc;
            }
            throw new Exception("Cannot unmarshal type Order");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Order)untypedValue;
            switch (value)
            {
                case Order.Asc:
                    serializer.Serialize(writer, "asc");
                    return;
                case Order.Desc:
                    serializer.Serialize(writer, "desc");
                    return;
            }
            throw new Exception("Cannot marshal type Order");
        }

        public static readonly OrderConverter Singleton = new OrderConverter();
    }


    internal class ImageTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImageTypeEnum) || t == typeof(ImageTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "hero":
                    return ImageTypeEnum.Hero;
                case "logo":
                    return ImageTypeEnum.Logo;
                case "mobile_hero":
                    return ImageTypeEnum.MobileHero;
                case "profile":
                    return ImageTypeEnum.Profile;
                case "background":
                    return ImageTypeEnum.Background;
                case "cover":
                    return ImageTypeEnum.Cover;
                case "poster":
                    return ImageTypeEnum.Poster;
                case "title_card":
                    return ImageTypeEnum.TitleCard;
                case "content_picture":
                    return ImageTypeEnum.ContentPicture;
            }
            throw new Exception("Cannot unmarshal type ImageTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImageTypeEnum)untypedValue;
            switch (value)
            {
                case ImageTypeEnum.Hero:
                    serializer.Serialize(writer, "hero");
                    return;
                case ImageTypeEnum.Logo:
                    serializer.Serialize(writer, "logo");
                    return;
                case ImageTypeEnum.MobileHero:
                    serializer.Serialize(writer, "mobile_hero");
                    return;
                case ImageTypeEnum.Profile:
                    serializer.Serialize(writer, "profile");
                    return;
                case ImageTypeEnum.Background:
                    serializer.Serialize(writer, "background");
                    return;
                case ImageTypeEnum.Cover:
                    serializer.Serialize(writer, "cover");
                    return;
                case ImageTypeEnum.Poster:
                    serializer.Serialize(writer, "poster");
                    return;
                case ImageTypeEnum.TitleCard:
                    serializer.Serialize(writer, "titlecard");
                    return;
            }
            throw new Exception("Cannot marshal type ImageTypeEnum");
        }

        public static readonly ImageTypeEnumConverter Singleton = new ImageTypeEnumConverter();
    }

    internal class OrientationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Orientation) || t == typeof(Orientation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch(value)
            {
                case "square":
                    return Orientation.Square;

                case "wide":
                    return Orientation.Wide;
            }

            //if (value == "wide")
            //{
            //    return Orientation.Wide;
            //}
            throw new Exception("Cannot unmarshal type Orientation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Orientation)untypedValue;
            if (value == Orientation.Wide)
            {
                serializer.Serialize(writer, "wide");
                return;
            }
            throw new Exception("Cannot marshal type Orientation");
        }

        public static readonly OrientationConverter Singleton = new OrientationConverter();
    }

    internal class ImageTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImageType) || t == typeof(ImageType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "episode_image":
                    return ImageType.EpisodeImage;
                case "show_image":
                    return ImageType.ShowImage;
                case "channel_image":
                    return ImageType.ChannelImage;
                case "livestream_show_image":
                    return ImageType.LivestreamShowImage;

            }
            throw new Exception("Cannot unmarshal type ImageType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImageType)untypedValue;
            switch (value)
            {
                case ImageType.EpisodeImage:
                    serializer.Serialize(writer, "episode_image");
                    return;
                case ImageType.ShowImage:
                    serializer.Serialize(writer, "show_image");
                    return;
            }
            throw new Exception("Cannot marshal type ImageType");
        }

        public static readonly ImageTypeConverter Singleton = new ImageTypeConverter();
    }

    internal class TagTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TagType) || t == typeof(TagType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "tag")
            {
                return TagType.Tag;
            }
            throw new Exception("Cannot unmarshal type TagType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TagType)untypedValue;
            if (value == TagType.Tag)
            {
                serializer.Serialize(writer, "tag");
                return;
            }
            throw new Exception("Cannot marshal type TagType");
        }

        public static readonly TagTypeConverter Singleton = new TagTypeConverter();
    }

}
