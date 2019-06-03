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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace RTUnofficial.App
{
    public sealed partial class EpisodesViewHorizontal : UserControl
    {

        private string _episode_source_url = ApiClient.Endpoints.Episodes;
        private ApiClient.RTPagedSource<ApiClient.Models.EpisodeData> _episodes = new ApiClient.RTPagedSource<ApiClient.Models.EpisodeData>();

        public delegate void EpisodeClickHandler(object source, ApiClient.Models.EpisodeData episode);
        public event EpisodeClickHandler OnEpisodeClick;

        public string EpisodeSourceUrl
        {
            get { return _episode_source_url; }
            set
            {
                _episode_source_url = value;
                _episodes = new ApiClient.RTPagedSource<ApiClient.Models.EpisodeData>() { Endpoint = value };
                _episodes.NextPage();
                Bindings.Update();
            }
        }
        public EpisodesViewHorizontal()
        {
            this.InitializeComponent();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnEpisodeClick(this, e.ClickedItem as ApiClient.Models.EpisodeData);
        }
    }
}
