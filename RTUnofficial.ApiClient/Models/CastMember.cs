using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    #region Classes
    public partial class CastMember
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("type")]
        public CastMemberType Type { get; set; }

        [JsonProperty("attributes")]
        public CastMemberAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public LinksClass Links { get; set; }

        [JsonProperty("included")]
        public DataIncluded Included { get; set; }
    }

    public partial class CastMemberAttributes
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
    #endregion

    #region Enums
    public enum CastMemberType { CastMember };

    #endregion

    #region Converter

    internal class CastMemberTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CastMemberType) || t == typeof(CastMemberType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "cast_member")
            {
                return CastMemberType.CastMember;
            }
            throw new Exception("Cannot unmarshal type CastMemberType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CastMemberType)untypedValue;
            if (value == CastMemberType.CastMember)
            {
                serializer.Serialize(writer, "cast_member");
                return;
            }
            throw new Exception("Cannot marshal type CastMemberType");
        }

        public static readonly CastMemberTypeConverter Singleton = new CastMemberTypeConverter();
    }
    #endregion

}
