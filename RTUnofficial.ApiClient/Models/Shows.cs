using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTUnofficial.ApiClient.Models
{
    public partial class Shows
    {
        [JsonProperty("data")]
        public List<ShowData> Data { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }

        public static Shows FromJson(string json) => JsonConvert.DeserializeObject<Shows>(json, Converter.Settings);
    }

    public partial class ShowData
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
        public ShowDataAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public ShowLinks Links { get; set; }

        [JsonProperty("canonical_links")]
        public CanonicalLinks CanonicalLinks { get; set; }

        [JsonProperty("included")]
        public DataIncluded Included { get; set; }
    }

    public partial class ShowDataAttributes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public object Rating { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

        [JsonProperty("is_sponsors_only")]
        public bool IsSponsorsOnly { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("channel_id")]
        public Guid ChannelId { get; set; }

        [JsonProperty("channel_slug")]
        public string ChannelSlug { get; set; }

        [JsonProperty("season_count")]
        public long SeasonCount { get; set; }

        [JsonProperty("episode_count")]
        public long EpisodeCount { get; set; }

        [JsonProperty("last_episode_golive_at")]
        public DateTimeOffset LastEpisodeGoliveAt { get; set; }

        [JsonProperty("season_order")]
        public Order SeasonOrder { get; set; }

        [JsonProperty("episode_order")]
        public Order EpisodeOrder { get; set; }

        [JsonProperty("blacklisted_countries")]
        public List<object> BlacklistedCountries { get; set; }
    }

    public partial class ShowLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("seasons")]
        public string Seasons { get; set; }

        [JsonProperty("bonus_features")]
        public string BonusFeatures { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }

        [JsonProperty("product_collections")]
        public string ProductCollections { get; set; }

        [JsonProperty("latest_episode")]
        public string LatestEpisode { get; set; }

        [JsonProperty("s1e1")]
        public string S1E1 { get; set; }
    }

    public partial class ShowDataIncluded
    {
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
    }
}
