using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    public partial class Seasons
    {
        [JsonProperty("data")]
        public List<SeasonData> Data { get; set; }

        public static Seasons FromJson(string json) => JsonConvert.DeserializeObject<Seasons>(json, Converter.Settings);
    }

    public partial class SeasonData
    {
        [JsonProperty("_index")]
        public string Index { get; set; }

        [JsonProperty("_type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("_score")]
        public object Score { get; set; }

        [JsonProperty("sort")]
        public List<long> Sort { get; set; }

        [JsonProperty("id")]
        public long DatumId { get; set; }

        [JsonProperty("type")]
        public TypeEnum DatumType { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("attributes")]
        public SeasonAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public SeasonLinks Links { get; set; }

        [JsonProperty("included")]
        public DataIncluded Included { get; set; }
    }

    public partial class SeasonAttributes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("show_id")]
        public Guid ShowId { get; set; }

        [JsonProperty("show_slug")]
        public string ShowSlug { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }
    }

    public partial class SeasonIncluded
    {
        [JsonProperty("images")]
        public List<object> Images { get; set; }
    }

    public partial class SeasonLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("episodes")]
        public string Episodes { get; set; }
    }


}
