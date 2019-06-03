using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Data;
using Windows.Foundation;
using Windows.UI.Xaml;

namespace RTUnofficial.ApiClient
{
    public class EpisodesRepo : ObservableCollection<Models.EpisodeData>, ISupportIncrementalLoading
    {
        private readonly HttpClient _client = new HttpClient();

        private List<Models.EpisodeData> _episodes = new List<Models.EpisodeData>();
        private Models.Episodes _last_request_result = null;

        public int PerPage { get; set; } = 24;
        public int Page { get; set; } = 1;
        public string Endpoint { get; set; } = Endpoints.Episodes;

        //public List<Models.EpisodeData> this[int page] { get { return _episodes.GetRange( (page - 1) * PerPage, PerPage); } }
        public EpisodesRepo()
        {
            
        }

        public async Task NextPage()
        {
            Page++;

            await LoadEpisodes();

            return;
        }

        private Uri BuildUri()
        {
            UriBuilder builder_ = new UriBuilder(Endpoint);

            builder_.Query = $"per_page={PerPage}&page={Page}";

            System.Diagnostics.Debug.WriteLine(builder_.Query);

            return builder_.Uri;
        }

        public async Task LoadEpisodes()
        {
            string data_ = await _client.GetStringAsync(BuildUri());

            _last_request_result = Models.Episodes.FromJson(data_);

            var dispatcher_ = Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher;
            await dispatcher_.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    _last_request_result.Data.ForEach(t => this.Add(t));
                }
            );

            
        }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {

            return Task.Run<LoadMoreItemsResult>(
                async () =>
                {
                    await NextPage();
                    return new LoadMoreItemsResult() { Count = (uint)_last_request_result.Data.Count };
                }).AsAsyncOperation<LoadMoreItemsResult>();

        }

        public bool HasMoreItems
        {
            get
            {
                if (_last_request_result != null)
                    return _last_request_result.Page < _last_request_result.TotalPages;
                else
                    return true;
            }
        }
    }
}
