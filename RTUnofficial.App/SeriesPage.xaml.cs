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
    public sealed partial class SeriesPage : Page
    {
        private ApiClient.RTPagedSource<ApiClient.Models.ShowData> _shows_source = new ApiClient.RTPagedSource<ApiClient.Models.ShowData>() { Endpoint = ApiClient.Endpoints.Shows };
        public SeriesPage()
        {
            this.InitializeComponent();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Frame.Navigate(typeof(SeasonsPage_old), e.ClickedItem);
            Frame.Navigate(typeof(SeasonsPage), e.ClickedItem);
        }
    }
}
