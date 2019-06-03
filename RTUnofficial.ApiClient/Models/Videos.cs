using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    public partial class Videos
    {
        [JsonProperty("data")]
        public List<VideoData> Data { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
    }

    public class VideoData
    {
        [JsonProperty("_index")]
        public string Index { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("_score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public long DatumId { get; set; }

        [JsonProperty("type")]
        public string DatumType { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("attributes")]
        public VideoAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public VideoLinks Links { get; set; }

        [JsonProperty("included")]
        public DataIncluded Included { get; set; }
    }

    public partial class VideoLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class VideoAttributes
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("content_id")]
        public long ContentId { get; set; }

        [JsonProperty("content_slug")]
        public string ContentSlug { get; set; }

        [JsonProperty("content_uuid")]
        public Guid ContentUuid { get; set; }

        [JsonProperty("public_golive_at")]
        public DateTimeOffset PublicGoliveAt { get; set; }

        [JsonProperty("sponsor_golive_at")]
        public DateTimeOffset SponsorGoliveAt { get; set; }

        [JsonProperty("member_golive_at")]
        public DateTimeOffset MemberGoliveAt { get; set; }

        [JsonProperty("frame_sizes")]
        public object FrameSizes { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("bandwidth")]
        public object Bandwidth { get; set; }

        [JsonProperty("embed")]
        public bool Embed { get; set; }

        [JsonProperty("is_sponsors_only")]
        public bool IsSponsorsOnly { get; set; }

        [JsonProperty("image_pattern_url")]
        public Uri ImagePatternUrl { get; set; }

        [JsonProperty("bif_url")]
        public Uri BifUrl { get; set; }

        [JsonProperty("ad_config")]
        public AdConfig AdConfig { get; set; }
    }

    public class VideoIncluded
    {

    }


    public partial class Videos
    {
        public static Videos FromJson(string json) => JsonConvert.DeserializeObject<Videos>(json, Converter.Settings);
    }
}
