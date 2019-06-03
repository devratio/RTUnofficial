using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.Foundation;
using System.Net;

namespace RTUnofficial.ApiClient
{
    public static class SVODRepo
    {
        private static HttpClient _client = new HttpClient();
        public static string Endpoint { get; set; } = Endpoints.SVOD;

        public static async Task<Models.PagedResponse<T>> GetPagedDataAsync<T>(string api_endpoint, int page = 1, int per_page = 24)
        {
            UriBuilder builder_ = new UriBuilder(Endpoint + api_endpoint);

            if(builder_.Query.Length > 0) // if any GET parameters already exist...
            {
                builder_.Query += '&';
            }
            else
            {
                builder_.Query += '?';
            }
            builder_.Query += $"per_page={per_page}&page={page}";

            System.Diagnostics.Debug.WriteLine(builder_.Query);

            HttpResponseMessage response_ = await _client.GetAsync(builder_.Uri);

            if (response_.IsSuccessStatusCode)
            {
                return Models.PagedResponse<T>.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        /* TRASH
        public static async Task<Models.PagedResponse<Models.ChannelData>> GetChannels()
        {
            HttpResponseMessage response_ = await _client.GetAsync(Endpoint + Endpoints.Channels);

            if (response_.IsSuccessStatusCode)
            {
                return Models.PagedResponse<Models.ChannelData>.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        public static async Task<Models.Livestreams> GetLivestreams()
        {
            HttpResponseMessage response_ = await _client.GetAsync(Endpoint + Endpoints.Livestreams);

            if (response_.IsSuccessStatusCode)
            {
                return Models.Livestreams.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        public static async Task<Models.Shows> GetShows(int page = 1, int per_page = 24, string link = Endpoints.Shows)
        {
            UriBuilder builder_ = new UriBuilder(Endpoint);

            builder_.Path = link;
            builder_.Query = $"per_page={per_page}&page={page}";

            System.Diagnostics.Debug.WriteLine(builder_.Query);

            HttpResponseMessage response_ = await _client.GetAsync(builder_.Uri);


            if (response_.IsSuccessStatusCode)
            {
                return Models.Shows.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        public static async Task<Models.Episodes> GetEpisodes(int page=1, int per_page=24, string link = Endpoints.Episodes)
        {
            UriBuilder builder_ = new UriBuilder(Endpoint + link);

            builder_.Query += $"per_page={per_page}&page={page}";

            System.Diagnostics.Debug.WriteLine(builder_.Query);

            HttpResponseMessage response_ = await _client.GetAsync(builder_.Uri);


            if (response_.IsSuccessStatusCode)
            {
                return Models.Episodes.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        
        public static async Task<Models.Seasons> GetSeasons(Models.ShowData show)
        {

            HttpResponseMessage response_ = await _client.GetAsync(Endpoint + show.Links.Seasons);

            if (response_.IsSuccessStatusCode)
            {
                return Models.Seasons.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }

        
        /// <summary>
        /// Gets the video data based on the episode provided
        /// </summary>
        /// <param name="episode"></param>
        /// <returns>video information or null if information could not be loaded</returns>
        public static async Task<Models.Videos> GetVideos(Models.EpisodeData episode)
        {

            HttpResponseMessage response_ = await _client.GetAsync(Endpoint + episode.Links.Videos);

            if(response_.IsSuccessStatusCode)
            {
                return Models.Videos.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        */
        public static async Task<Models.Seasons> GetSeasons(Models.ShowData show)
        {

            HttpResponseMessage response_ = await _client.GetAsync(Endpoint + show.Links.Seasons);

            if (response_.IsSuccessStatusCode)
            {
                return Models.Seasons.FromJson(await response_.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
    }
}
