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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RTUnofficial.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SeasonsPage_old : Page
    {
        private ApiClient.Models.Seasons _seasons = null;
        public SeasonsPage_old()
        {
            this.InitializeComponent();
            
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter != null && e.Parameter is ApiClient.Models.ShowData)
            {
                _seasons = await ApiClient.SVODRepo.GetSeasons((ApiClient.Models.ShowData)e.Parameter);
            }
            Bindings.Update();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(EpisodesPage), ((ApiClient.Models.SeasonData)e.ClickedItem).Links.Episodes);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var seasons_box_ = sender as ComboBox;

            if(seasons_box_.SelectedItem != null)
            {
                episodes_frame.Navigate(typeof(EpisodesPage), ((ApiClient.Models.SeasonData)seasons_box_.SelectedItem).Links.Episodes);
            }
        }
    }
}
