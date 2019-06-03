using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

/*

namespace RTUnofficial.ApiClient
{
    public class ShowsSource : ObservableCollection<Models.ShowData>, ISupportIncrementalLoading
    {
        private Models.Shows _last_request_result = null;

        public int PerPage { get; set; } = 24;
        public int Page { get; set; } = 1;
        public string Endpoint { get; set; } = Endpoints.Shows;

        public ShowsSource()
        {

        }

        public async Task NextPage()
        {
            Page++;

            await Load();

            return;
        }

        public async Task Load()
        {
            _last_request_result = await SVODRepo.GetShows(Page, PerPage, Endpoint);

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
*/