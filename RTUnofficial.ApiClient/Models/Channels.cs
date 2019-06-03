using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RTUnofficial.ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTUnofficial.ApiClient.Models
{
    public partial class Channels
    {
        [JsonProperty("data")]
        public List<ChannelData> Data { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }

        public static Channels FromJson(string json) => JsonConvert.DeserializeObject<Channels>(json, Converter.Settings);
    }

    public partial class ChannelData
    {
        [JsonProperty("_index")]
        public string Index { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }

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
        public string DatumType { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("attributes")]
        public ChannelDataAttributes Attributes { get; set; }

        [JsonProperty("included")]
        public DataIncluded Included { get; set; }

        [JsonProperty("links")]
        public ChannelLinks Links { get; set; }
    }
    public class ChannelLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("shows")]
        public string Shows { get; set; }

        [JsonProperty("movies")]
        public string Movies { get; set; }

        [JsonProperty("product_collections")]
        public string ProductCollections { get; set; }

        [JsonProperty("featured_items")]
        public string FeaturedItems { get; set; }

        [JsonProperty("episodes")]
        public string Episodes { get; set; }

        [JsonProperty("livestreams")]
        public string Livestreams { get; set; }
    }
    public partial class ChannelDataAttributes
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("importance")]
        public long Importance { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("brand_color")]
        public string BrandColor { get; set; }
    }

    public partial class ChannelDataIncluded
    {
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
    }
}
