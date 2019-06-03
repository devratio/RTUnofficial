using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    public partial class Livestreams
    {
        [JsonProperty("data")]
        public List<LivestreamData> Data { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }


        public static Livestreams FromJson(string json) => JsonConvert.DeserializeObject<Livestreams>(json, Converter.Settings);
    }

    public partial class LivestreamData
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
        public LivestreamDataAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public LivestreamLinks Links { get; set; }

        [JsonProperty("canonical_links")]
        public CanonicalLinks CanonicalLinks { get; set; }

        [JsonProperty("included")]
        public DataIncluded Included { get; set; }
    }

    public partial class LivestreamDataAttributes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("starts_at")]
        public DateTimeOffset StartsAt { get; set; }

        [JsonProperty("ends_at")]
        public DateTimeOffset EndsAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("hashtag")]
        public string Hashtag { get; set; }

        [JsonProperty("widget_id")]
        public string WidgetId { get; set; }

        [JsonProperty("source_url")]
        public Uri SourceUrl { get; set; }

        [JsonProperty("embed")]
        public object Embed { get; set; }

        [JsonProperty("permission_level")]
        public string PermissionLevel { get; set; }

        [JsonProperty("is_sponsors_only")]
        public bool IsSponsorsOnly { get; set; }

        [JsonProperty("member_tier_i")]
        public long MemberTierI { get; set; }

        [JsonProperty("stream_type")]
        public string StreamType { get; set; }

        [JsonProperty("channel_uuid")]
        public Guid ChannelUuid { get; set; }

        [JsonProperty("channel_slug")]
        public string ChannelSlug { get; set; }

        [JsonProperty("programming_type")]
        public string ProgrammingType { get; set; }

        [JsonProperty("parent_uuid")]
        public Guid ParentUuid { get; set; }

        [JsonProperty("third_party_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ThirdPartyId { get; set; }

        [JsonProperty("stream_key")]
        public object StreamKey { get; set; }
    }

    public partial class LivestreamDataIncluded
    {
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
    }

    public partial class LivestreamLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }
    }
}
