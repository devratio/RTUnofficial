using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RTUnofficial.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EpisodesPage : Page
    {
        private ApiClient.RTPagedSource<ApiClient.Models.EpisodeData> _episodes_repo = new ApiClient.RTPagedSource<ApiClient.Models.EpisodeData>() { Endpoint = ApiClient.Endpoints.Episodes };
        //private ApiClient.Models.Episodes _episodes;

        public EpisodesPage()
        {
            this.InitializeComponent();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(MediaPage), e.ClickedItem);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter != null && e.Parameter is string)
            {
                _episodes_repo.Endpoint = (string)e.Parameter;
            }
        }

    }
}
