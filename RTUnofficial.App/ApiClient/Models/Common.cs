using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    // really the main data type returned from RT apis is just a container with "included" data and attributes,
    // unfortunately this means that it contains variable typed classes within it, so it is not easily modeled with
    // traditional POCO classes(would require using dynamic types). this is why I decided to repeat myself and have
    // each class individually defined - while using these common files to define data types used throughout

    #region Classes
    public partial class CanonicalLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("show")]
        public string Show { get; set; }
    }


    public partial class LinksClass
    {
    }

    public partial class Image
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("type")]
        public ImageType Type { get; set; }

        [JsonProperty("attributes")]
        public ImageAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public LinksClass Links { get; set; }

        [JsonProperty("included")]
        public LinksClass Included { get; set; }
    }

    public partial class ImageAttributes
    {
        [JsonProperty("thumb")]
        public Uri Thumb { get; set; }

        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("medium")]
        public Uri Medium { get; set; }

        [JsonProperty("large")]
        public Uri Large { get; set; }

        [JsonProperty("orientation")]
        public Orientation Orientation { get; set; }

        [JsonProperty("image_type")]
        public ImageTypeEnum ImageType { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }

        [JsonProperty("uuid")]
        public Guid? Uuid { get; set; }

        [JsonProperty("type")]
        public TagType Type { get; set; }

        [JsonProperty("attributes")]
        public TagAttributes Attributes { get; set; }

        [JsonProperty("links")]
        public LinksClass Links { get; set; }

        [JsonProperty("included")]
        public LinksClass Included { get; set; }
    }

    public partial class TagAttributes
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("show")]
        public string Show { get; set; }

        [JsonProperty("related_shows")]
        public string RelatedShows { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("videos")]
        public string Videos { get; set; }

        [JsonProperty("products")]
        public string Products { get; set; }

        [JsonProperty("parent_episode", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentEpisode { get; set; }

        [JsonProperty("after_show_episode", NullValueHandling = NullValueHandling.Ignore)]
        public string AfterShowEpisode { get; set; }
    }
#endregion

    #region Enums
    //public enum ChannelSlug { AchievementHunter, CowChop, Funhaus, InsideGaming, JtMusic, KindaFunny, RoosterTeeth, Screwattack, SugarPine7 };

    public enum Order { Asc, Desc };

    public enum TypeEnum { Episode };

    public enum ImageTypeEnum { Hero, Logo, MobileHero, Profile };

    public enum Orientation { Wide };

    public enum ImageType { EpisodeImage, ShowImage };

    public enum TagType { Tag };

    //public enum Index { EpisodesProductionEn20190510090020722 };

    //public enum Channel { ApiV1ChannelsAchievementHunter, ApiV1ChannelsCowChop, ApiV1ChannelsFunhaus, ApiV1ChannelsInsideGaming, ApiV1ChannelsJtMusic, ApiV1ChannelsKindaFunny, ApiV1ChannelsRoosterTeeth, ApiV1ChannelsScrewattack, ApiV1ChannelsSugarPine7 };
    #endregion

}
