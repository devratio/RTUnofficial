using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

namespace RTUnofficial.ApiClient
{
    public class RTPagedSource<T> : ObservableCollection<T>, ISupportIncrementalLoading
    {
        private Models.PagedResponse<T> _last_request_result = null;

        public int PerPage { get; set; } = 24;
        public int Page { get; set; } = 1;
        public string Endpoint { get; set; }

        private bool _first_page_loaded = false;

        public async Task LoadAsync()
        {
            _last_request_result = await SVODRepo.GetPagedDataAsync<T>(Endpoint, Page, PerPage);

            var dispatcher_ = Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher;
            await dispatcher_.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    _last_request_result.Data.ForEach(t => this.Add(t));
                }
            );


        }

        public async Task NextPage()
        {
            if (_first_page_loaded) // workaround for loading the first page,
                                    // just so i dont have to call any method to load data
            {
                Page++;
            }
            else
            {
                _first_page_loaded = true;
            }

            await LoadAsync();

            return;
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
