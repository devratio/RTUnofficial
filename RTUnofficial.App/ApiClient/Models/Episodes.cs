// classes generated from json automatically using quicktype.io (https://quicktype.io)
// this file from https://svod-be.roosterteeth.com/api/v1/episodes?per_page=1
// TODONE: go through these and fix up any inconsistencies or incorrect types
// TODO: add testing for schema consistency 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RTUnofficial.ApiClient.Models
{
    #region Data definitions
    public partial class Episodes
    {
        [JsonProperty("data")]
        public List<EpisodeData> Data { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
    }

    public partial class EpisodeData
    {
        [JsonProperty("_index")]
        public string Index { get; set; }
        //public Index Index { get; set; } // ... idk really

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
        public EpisodeDataAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("canonical_links")]
        public CanonicalLinks CanonicalLinks { get; set; }

        [JsonProperty("included")]
        public EpisodeDataIncluded Included { get; set; }
    }

    public partial class EpisodeDataAttributes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("rating")]
        public object Rating { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("display_title")]
        public string DisplayTitle { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }

        public TimeSpan LengthTS
        {
            get { return new TimeSpan(Length * 10000000); }
        }

        [JsonProperty("advert_config")]
        public string AdvertConfig { get; set; }

        [JsonProperty("advertising")]
        public bool Advertising { get; set; }

        [JsonProperty("ad_timestamps")]
        public string AdTimestamps { get; set; }

        [JsonProperty("public_golive_at")]
        public DateTimeOffset PublicGoliveAt { get; set; }

        [JsonProperty("sponsor_golive_at")]
        public DateTimeOffset SponsorGoliveAt { get; set; }

        [JsonProperty("member_golive_at")]
        public DateTimeOffset MemberGoliveAt { get; set; }

        [JsonProperty("original_air_date")]
        public DateTimeOffset OriginalAirDate { get; set; }

        [JsonProperty("channel_id")]
        public Guid ChannelId { get; set; }

        [JsonProperty("channel_slug")]
        public string ChannelSlug { get; set; } 

        [JsonProperty("season_id")]
        public Guid SeasonId { get; set; }

        [JsonProperty("season_slug")]
        public string SeasonSlug { get; set; }

        [JsonProperty("season_number")]
        public long SeasonNumber { get; set; }

        [JsonProperty("show_title")]
        public string ShowTitle { get; set; }

        [JsonProperty("show_id")]
        public Guid ShowId { get; set; }

        [JsonProperty("show_slug")]
        public string ShowSlug { get; set; }

        [JsonProperty("is_sponsors_only")]
        public bool IsSponsorsOnly { get; set; }

        [JsonProperty("member_tier_i")]
        public long MemberTierI { get; set; }

        [JsonProperty("sort_number")]
        public long SortNumber { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

        [JsonProperty("is_live")]
        public bool IsLive { get; set; }

        [JsonProperty("is_schedulable")]
        public bool IsSchedulable { get; set; }

        [JsonProperty("season_order")]
        public Order? SeasonOrder { get; set; }

        [JsonProperty("episode_order")]
        public Order EpisodeOrder { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("blacklisted_countries")]
        public List<object> BlacklistedCountries { get; set; }

        [JsonProperty("upsell_next")]
        public bool UpsellNext { get; set; }

        [JsonProperty("parent_episode_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentEpisodeId { get; set; }

        [JsonProperty("after_show_episode_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AfterShowEpisodeId { get; set; }
    }


    public partial class EpisodeDataIncluded
    {
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("cast_members")]
        public List<CastMember> CastMembers { get; set; }
    }


    #endregion

    #region Converters
    public partial class Episodes
    {
        public static Episodes FromJson(string json) => JsonConvert.DeserializeObject<Episodes>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Episodes self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
    #endregion

}
