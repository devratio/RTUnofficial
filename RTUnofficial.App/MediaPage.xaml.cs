using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RTUnofficial.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MediaPage : Page
    {
        private ApiClient.Models.EpisodeData _episode_data = null;
        private ApiClient.Models.PagedResponse<ApiClient.Models.VideoData> _video = null;
        public MediaPage()
        {
            this.InitializeComponent();
        }

        private void ShowPaywall()
        {
            media_element.Visibility = Visibility.Collapsed;
            paywall.Visibility = Visibility.Visible;
        }

        private void HidePaywall()
        {
            media_element.Visibility = Visibility.Visible;
            paywall.Visibility = Visibility.Collapsed;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter == null)
            {
                await new MessageDialog("Whoops! something went wrong.\r\nError: MediaPage::OnNavigatedTo, e.parameter == null").ShowAsync();
            }

            if (e.Parameter is ApiClient.Models.EpisodeData)
            {
                _episode_data = (ApiClient.Models.EpisodeData)e.Parameter;
                _video = await ApiClient.SVODRepo.GetPagedDataAsync<ApiClient.Models.VideoData>(_episode_data.Links.Videos);

                if (_video != null)
                {
                    HidePaywall();
                    media_element.Source = _video.Data.First().Attributes.Url;
                }
                else
                {
                    ShowPaywall();
                }
            }
            else if(e.Parameter is ApiClient.Models.LivestreamData)
            {
                var livestream_data_ = e.Parameter as ApiClient.Models.LivestreamData;

                HidePaywall();
                media_element.Source = livestream_data_.Attributes.SourceUrl;
            }


        }
    }
}
